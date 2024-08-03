namespace SWAD
{
    internal class DebitCard : Payment
    {
        private string debitCardNo;

        private DateTime debitCardExpiryDate;

        private string debitCardName;
        public string DebitCardNo { get; set; }

        public DateTime DebitCardExpiryDate { get; set; }

        public string DebitCardName{ get; set; }

        public DebitCard(string debitCardNo, DateTime debitCardExpiryDate, string debitCardName)
        {
            DebitCardNo = debitCardNo;
            DebitCardExpiryDate = debitCardExpiryDate;
            DebitCardName = debitCardName;
        }
    }
}
