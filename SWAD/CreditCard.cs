namespace SWAD
{
    internal class CreditCard : Payment
    {
        private string creditCardNo;

        private DateTime creditCardExpiryDate;

        private string dcreditCardName;
        public string CreditCardNo { get; set; }

        public DateTime CreditCardExpiryDate { get; set; }

        public string CreditCardName { get; set; }

        public CreditCard(string creditCardNo, DateTime creditCardExpiryDate, string creditCardName)
        {
            CreditCardNo = creditCardNo;
            CreditCardExpiryDate = creditCardExpiryDate;
            CreditCardName = creditCardName;
        }
    }
}
