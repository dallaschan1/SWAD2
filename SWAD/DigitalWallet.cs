using System;

namespace Assignment2
{
    internal class DigitalWallet
    {
        private string walletProvider;
        private string providerUserId;
        private string password;
        private string walletEmail;
        private string? walletPhoneNumber;

        private const string StoredPassword = "newAlex345"; // Moved inside the class

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
            // Compare the entered password with the stored password
            return password == StoredPassword;
        }

        public void SendAmount()
        {
            double pricePerHour = 7.50;
            int hoursBooked = 5;
            double total = pricePerHour * hoursBooked;

            Console.WriteLine($"Total Amount: ${total:F2}");
        }

        public void SendWalletDetails(string walletProvider, string providerUserId, string password, string walletEmail, string? walletPhoneNumber)
        {
            Console.WriteLine($"Wallet Provider: {walletProvider}");
            Console.WriteLine($"Wallet Provider ID: {providerUserId}");
            Console.WriteLine($"Password: {password}");
            Console.WriteLine($"Wallet Email: {walletEmail}");
            Console.WriteLine($"Wallet Phone Number: {walletPhoneNumber}");
        }
    }
}
