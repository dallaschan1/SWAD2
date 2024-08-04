namespace Assignment2
{
    internal class CreditCard : Payment
    {
        private string creditCardNo;
        private DateTime creditCardExpiryDate;
        private string creditCardName;

        public string CreditCardNo
        {
            get { return creditCardNo; }
            set { creditCardNo = value; }
        }
        public DateTime CreditCardExpiryDate
        {
            get { return creditCardExpiryDate; }
            set { creditCardExpiryDate = value; }
        }
        public string CreditCardName
        {
            get { return creditCardName; }
            set { creditCardName = value; }
        }

        public CreditCard(string creditCardNo, DateTime creditCardExpiryDate, string creditCardName, string paymentMethod, double amount)
            : base(paymentMethod, amount)
        {
            CreditCardNo = creditCardNo;
            CreditCardExpiryDate = creditCardExpiryDate;
            CreditCardName = creditCardName;
        }
    }
}
