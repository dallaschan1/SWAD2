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


        public bool IsValidWalletProvider(string walletProvider)
        {
            // List of valid wallet providers
            string[] validProviders = { "Apple Pay", "Google Pay", "PayPal", "Alipay" };

            foreach (var provider in validProviders)
            {
                if (walletProvider.Equals(provider, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsPasswordValid(string password)
        {
            // List of valid passwords
            string[] validPasswords = { "newAlex345", "Alex123", "alexNew22", "thisIsAlex" };

            foreach (var validPassword in validPasswords)
            {
                if (validPassword.Equals(password, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }


        public void sendAmount(ref double total)
        {
            double pricePerHour = 7.50;
            int hoursBooked = 5;
            total = pricePerHour * hoursBooked;

            Console.WriteLine($"Total Amount: ${total:F2}");
        }
    }
}
