using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static Assignment2.Rental;

namespace Assignment2
{
    internal class Renter : Account
    {
        private int renterId;
        private string renterStatus;
        private string issuingCountry;
        private string classOfLicense;
        private double amountSpent;
        private bool verified;
        private DateTime dateOfBirth;
        private string licenseNumber;
        private DateTime licenseExpiry;
        private List<Rental> rentals = new List<Rental>();

        public int RenterId
        {
            get { return renterId; }
            set { renterId = value; }
        }
        public string RenterStatus
        {
            get { return renterStatus; }
            set { renterStatus = value; }
        }
        public string IssuingCountry
        {
            get { return issuingCountry; }
            set { issuingCountry = value; }
        }
        public string ClassOfLicense
        {
            get { return classOfLicense; }
            set { classOfLicense = value; }
        }
        public double AmountSpent
        {
            get { return amountSpent; }
            set { amountSpent = value; }
        }
        public bool Verified
        {
            get { return verified; }
            set { verified = value; }
        }
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        public string LicenseNumber
        {
            get { return licenseNumber; }
            set { licenseNumber = value; }
        }
        public DateTime LicenseExpiry
        {
            get { return licenseExpiry; }
            set { licenseExpiry = value; }
        }
        public List<Rental> Rentals
        {
            get { return rentals; }
           
        }

        public Renter(string username, string password, string email, string fullName, string phoneNo,DateTime dateOfBirth, string licenseNumber, DateTime licenseExpiry, int renterId, string renterStatus, string issuingCountry, string classOfLicense, double amountSpent, bool verified): base(username, password, email, fullName, phoneNo)
        {
            DateOfBirth = dateOfBirth;
            LicenseNumber = licenseNumber;
            LicenseExpiry = licenseExpiry;
            RenterId = renterId;
            RenterStatus = renterStatus;
            IssuingCountry = issuingCountry;
            ClassOfLicense = classOfLicense;
            AmountSpent = amountSpent;
            Verified = verified;
            
        }

        public Rental getPendingOrder()
        {
            foreach (Rental rental in rentals)
            {
                if (rental.RentalStatus == RentalStatuses.InProgress)
                {
                    return rental;
                }
            }
            return null;
        }


        public void updateRental(RentalStatuses Status)
        {
            foreach (Rental rental in rentals)
            {
                if (rental.RentalStatus == RentalStatuses.InProgress)
                {
                    rental.updateRental(Status);
                }
            }
        }

        public void deleteRental()
        {
            foreach (Rental rental in rentals)
            {
                if (rental.RentalStatus == RentalStatuses.InProgress)
                {
                    rentals.Remove(rental);
                }
            }
        }
    }
}
