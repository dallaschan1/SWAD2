using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment2
{
    internal class Rental
    {
        // Private fields
        private int rentalId;
        private DateTime startDate;
        private DateTime endDate;
        private string rentalStatus;
        private string? pickUpAddress;
        private string? deliveryAddress;
        private DateTime returnedDate;
        private double cost;


        // Public properties
        public int RentalId
        {
            get { return rentalId; }
            set { rentalId = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public string RentalStatus
        {
            get { return rentalStatus; }
            set { rentalStatus = value; }
        }

        public string PickUpAddress
        {
            get { return pickUpAddress; }
            set { pickUpAddress = value; }
        }

        public string DeliveryAddress
        {
            get { return deliveryAddress; }
            set { deliveryAddress = value; }
        }

        public DateTime ReturnedDate
        {
            get { return returnedDate; }
            set { returnedDate = value; }
        }

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        // Constructor
        public Rental(int rentalId, DateTime startDate, DateTime endDate, string rentalStatus, string pickUpAddress, string deliveryAddress, DateTime returnedDate, int cost)
        {
            RentalId = rentalId;
            StartDate = startDate;
            EndDate = endDate;
            RentalStatus = rentalStatus;
            PickUpAddress = pickUpAddress;
            DeliveryAddress = deliveryAddress;
            ReturnedDate = returnedDate;
            Cost = cost;
        }
    }
}
