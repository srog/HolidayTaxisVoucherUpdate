using System.Runtime.Serialization;
using Otb.Entities.Entities;

namespace HolidayTaxisEmails
{
    [DataContract]
    public class UpdateVoucherRequest : DataContractImmutable<UpdateVoucherRequest>
    {
        public UpdateVoucherRequest(string bookingReference, string voucherText)
        {
            Transfer = new Transfer(bookingReference, voucherText);
        }
        [DataMember]
        public Transfer Transfer { get; private set; }
    }
}
