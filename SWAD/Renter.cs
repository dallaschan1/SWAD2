using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Renter : Account
    {
        private int renterid;
        private string renterStatus;
        private string issuingCountry;
        private string classOfLicense;
        private double amountSpent;
        private bool verified;

        private string dateOfBirth;
        private string licenseNumber;
        private string licenseExpiry;

        public int renterId { get; set; }
        public string RenterStatus { get; set; }
        public string IssuingCountry { get; set; }
        public string ClassOfLicense { get; set; }
        public double AmountSpent { get; set; }
        public bool Verified { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string LicenseNumber { get; set; }
        public DateTime LicenseExpiry { get; set; }

        public Renter(string username, string password, string email, string fullName, string phoneNo, string dateOfBirth, string licenseNumber, string licenseExpiry, int renterId
            , string renterStatus, string issuingCountry, string classOfLicense, double amountSpent, bool verified)
            : base(username, password, email, fullName, phoneNo)
        {
        }
    }
}
