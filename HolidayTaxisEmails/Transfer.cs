using System.Runtime.Serialization;
using Otb.Entities.Entities;

namespace HolidayTaxisEmails
{
    [DataContract]
    public class Transfer : DataContractImmutable<Transfer>
    {
        public Transfer(string bookingReference, string voucherText)
        {
            Voucher = voucherText;
            Reference = bookingReference;
        }

        [DataMember]
        public string Voucher { get; private set; }

        [DataMember]
        public string Reference { get; private set; }

    }
}
