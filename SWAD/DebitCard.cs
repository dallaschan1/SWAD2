namespace Assignment2
{
    internal class DebitCard : Payment
    {
        private string debitCardNo;
        private DateTime debitCardExpiryDate;
        private string debitCardName;

        public string DebitCardNo
        {
            get { return debitCardNo; }
            set { debitCardNo = value; }
        }
        public DateTime DebitCardExpiryDate
        {
            get { return debitCardExpiryDate; }
            set { debitCardExpiryDate = value; }
        }
        public string DebitCardName
        {
            get { return debitCardName; }
            set { debitCardName = value; }
        }

        public DebitCard(string debitCardNo, DateTime debitCardExpiryDate, string debitCardName, string paymentMethod, double amount)
            : base(paymentMethod, amount)
        {
            DebitCardNo = debitCardNo;
            DebitCardExpiryDate = debitCardExpiryDate;
            DebitCardName = debitCardName;
        }
    }
}
