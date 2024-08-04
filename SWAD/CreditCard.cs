namespace Assignment2
{
    internal class CreditCard : Payment
    {
        private string creditCardNo;

        private DateTime creditCardExpiryDate;

        private string creditCardName;
        public string CreditCardNo { get; set; }

        public DateTime CreditCardExpiryDate { get; set; }

        public string CreditCardName { get; set; }

        public CreditCard(string creditCardNo, DateTime creditCardExpiryDate, string creditCardName, string CreditCard, double amount)
            : base(CreditCard, amount)
        {
        }
    }
}
