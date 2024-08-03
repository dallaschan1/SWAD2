namespace SWAD
{
    internal class DigitalWallet
    {
        public string WalletProvider { get; set; }

        public string ProviderUserId { get; set; }

        public string Password { get; set; }

        public string WalletEmail { get; set; }

        public string? WalletPhoneNumber { get; set; }

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