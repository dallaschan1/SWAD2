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
        private string? pickUpAddress;
        private string? deliveryAddress;
        private DateTime returnedDate;
        private double cost;
        private Payment? payment;
        private List<Review> reviews = new List<Review>();
        private VehicleInspection vehicleInspection;
        private List<Accident> accidents = new List<Accident>();
        private Car car;
        private ICarStation pickUpICarStation;
        private ICarStation returnICarStation;

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
        public string? PickUpAddress
        {
            get { return pickUpAddress; }
            set { pickUpAddress = value; }
        }
        public string? DeliveryAddress
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
        public Payment? Payment
        {
            get { return payment; }
            set { payment = value; }
        }
        public List<Review> Reviews
        {
            get { return reviews; }
           
        }
        public VehicleInspection VehicleInspection
        {
            get { return vehicleInspection; }
            set { vehicleInspection = value; }
        }
        public List<Accident> Accidents
        {
            get { return accidents; }
      
        }
        public Car Car
        {
            get { return car; }
            set { car = value; }
        }
        public ICarStation PickUpICarStation
        {
            get { return pickUpICarStation; }
            set { pickUpICarStation = value; }
        }
        public ICarStation ReturnICarStation
        {
            get { return returnICarStation; }
            set { returnICarStation = value; }
        }

        public Rental(int rentalId, DateTime startDate, DateTime endDate, string rentalStatus, string? pickUpAddress, string? deliveryAddress, DateTime returnedDate, double cost)
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
