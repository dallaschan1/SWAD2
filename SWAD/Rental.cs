using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Rental
    {
        private int rentalId;

        private DateTime startDate;

        private DateTime endDate;

        private string rentalStatus;

        private string pickUpMethod;

        private string returnMethod;

        private DateTime returnedDate;

        public int RentalId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string RentalStatus { get; set;}

        public string PickUpMethod { get; set;}

        public string ReturnMethod { get; set;}

        public DateTime ReturnedDate { get; set; }

        // Constructor
        public Rental(int rentalId, DateTime startDate, DateTime endDate, string rentalStatus, string pickUpMethod, string returnMethod, DateTime returnedDate)
        {
            RentalId = rentalId;
            StartDate = startDate;
            EndDate = endDate;
            RentalStatus = rentalStatus;
            PickUpMethod = pickUpMethod;
            ReturnMethod = returnMethod;
            ReturnedDate = returnedDate;
        }
    }
}
