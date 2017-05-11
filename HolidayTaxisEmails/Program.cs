using System;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.ServiceModel;
using Dapper;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace HolidayTaxisEmails
{
    public class Program
    {
        static void Main(string[] args)
        {
            // TEST
            Run("https://www.sandbox5.onthebeach.co.uk/a/admin/api/v3/transfers/", 
                "Data Source=localhost\\SQLEXPRESS;Database=Transfers;Integrated Security=true",
                "http://localhost:4149/service/TaxiBookingAPI.asmx",
                150,
                false);

            // LIVE
            //Run("https://www.onthebeach.co.uk/a/admin/api/v3/transfers/",
            //    "Data Source=172.21.3.114;Initial Catalog=OnTheBeachTransfers;Integrated Security=True;multipleactiveresultsets=True;App=HolidayTaxisVoucherUpdate",
            //    "http://www.onthebeachtransfers.co.uk/service/TaxiBookingAPI.asmx",
            //    100);
            //    true);

        }
        private static void Run(string adminEndpoint, string connectionString, string apiEndpoint, 
                                int recordsToProcess, bool updateVoucher)
        { 
            var api = new TaxiBookingApi.TaxiBookingAPISoapClient(
                new BasicHttpBinding(), 
                new EndpointAddress(apiEndpoint));

            SqlConnection conn = new SqlConnection(connectionString);
            
            using (conn)
            {
                var getBookingsSql =
                    $"SELECT TOP {recordsToProcess} BookingReference FROM dbo.BookingsRegeneratePaperwork WHERE PaperworkRegenerated = 0 ORDER BY DepartureDate";
                
                var bookingList = conn.Query<Booking>(getBookingsSql);
                Console.WriteLine("Number of Bookings To Process: " + bookingList.Count());
                var countSuccess = 0;

                foreach (var booking in bookingList)
                {
                    var voucherText = api.GetConfirmationEmail(booking.BookingReference, "V");

                    if (updateVoucher)
                    {
                        UpdateVoucher(adminEndpoint, booking.BookingReference.ToString(), voucherText);
                    }

                    // UPDATE NEW DB TABLE
                    var result = conn.Execute(
                        "Update BookingsRegeneratePaperwork SET PaperworkRegenerated = 1 WHERE BookingReference = @bookref",
                        new { bookref = booking.BookingReference});

                    if (result == 1)
                    {
                        countSuccess++;
                    }
                    else
                    {
                        Console.WriteLine("Error processing booking: " + booking.BookingReference);
                    }
                }

                Console.WriteLine("Total Number of Bookings Processed Successfully: " + countSuccess);
                Console.ReadLine();
            }
        }
        
        public static void UpdateVoucher(string endpoint, string bookingReference, string voucherText)
        {
            var client = new WebClient();
            client.Headers.Add("Content-Type", "application/json; charset=utf-8");
            client.Headers.Add("User-Agent", "8879d16381c2b99263383b5cea685a379ef1b98c");
            client.Headers.Add("X-AUTH-TOKEN", "8879d16381c2b99263383b5cea685a379ef1b98c");
            var endpointAddress = endpoint + bookingReference;

            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            var payload = JsonConvert.SerializeObject(new UpdateVoucherRequest(bookingReference, voucherText), settings);
            client.UploadString(endpointAddress, "PUT", payload);
        }
    }
}
