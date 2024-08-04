namespace Assignment2
{
    internal class DigitalWallet
    {
        private string walletProvider;
        private string providerUserId;
        private string password;
        private string walletEmail;
        private string? walletPhoneNumber;

        public string WalletProvider
        {
            get { return walletProvider; }
            set { walletProvider = value; }
        }
        public string ProviderUserId
        {
            get { return providerUserId; }
            set { providerUserId = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string WalletEmail
        {
            get { return walletEmail; }
            set { walletEmail = value; }
        }
        public string? WalletPhoneNumber
        {
            get { return walletPhoneNumber; }
            set { walletPhoneNumber = value; }
        }

        public DigitalWallet(string walletProvider, string providerUserId, string password, string walletEmail, string? walletPhoneNumber)
        {
            WalletProvider = walletProvider;
            ProviderUserId = providerUserId;
            Password = password;
            WalletEmail = walletEmail;
            WalletPhoneNumber = walletPhoneNumber;
        }
    }
}