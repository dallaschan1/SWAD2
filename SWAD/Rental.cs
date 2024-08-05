using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment2.Rental;


namespace Assignment2
{
    internal class Rental
    {
        // I Use Enum Here to ensure the Rental Status is the following 3 only
        public enum RentalStatuses
        {
            InProgress,
            Started,
            Completed
        }

        private int rentalId;
        private DateTime startDate;
        private DateTime endDate;
        private RentalStatuses rentalStatus;
        private string? deliveryAddress;
        private string? dropOffAddress;
        private DateTime? returnedDate;
        private DateTime rentalStartDate;
        private double cost;
        private Payment? payment;
        private List<Review> reviews = new List<Review>();
        private VehicleInspection? vehicleInspection;
        private List<Accident> accidents = new List<Accident>();
        private Car car;
        private ICarStation pickUpICarStation;
        private ICarStation dropOffICarStation;

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
        public RentalStatuses RentalStatus
        {
            get { return rentalStatus; }
            set { rentalStatus = value; }
        }
        public string? DeliveryAddress
        {
            get { return deliveryAddress; }
            set { deliveryAddress = value; }
        }
        public string? DropOffAddress
        {
            get { return dropOffAddress; }
            set { dropOffAddress = value; }
        }
        public DateTime? ReturnedDate
        {
            get { return returnedDate; }
            set { returnedDate = value; }
        }
        public DateTime RentalStartDate
        {
            get { return rentalStartDate; }
            set { rentalStartDate = value; }
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
        public VehicleInspection? VehicleInspection
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
        public ICarStation DropOffICarStation
        {
            get { return dropOffICarStation; }
            set { dropOffICarStation = value; }
        }

        public Rental(int rentalId, DateTime startDate, DateTime endDate, RentalStatuses rentalStatus, string? dropOffAddress, string? deliveryAddress, double cost, Car car, ICarStation dropOffICarStation, ICarStation pickUpICarStation)
        {
            RentalId = rentalId;
            StartDate = startDate;
            EndDate = endDate;
            RentalStatus = rentalStatus;
            DeliveryAddress = deliveryAddress;
            RentalStartDate = DateTime.Now;
            DropOffAddress = dropOffAddress;
         
            Cost = cost;
            Car = car;
            PickUpICarStation = pickUpICarStation;
            DropOffICarStation = dropOffICarStation;
            
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Rental Details:");
            sb.AppendLine($"Rental ID: {RentalId}");
            sb.AppendLine($"Start Date: {StartDate.ToString("yyyy-MM-dd HH:mm")}");
            sb.AppendLine($"End Date: {EndDate.ToString("yyyy-MM-dd HH:mm")}");
            sb.AppendLine($"Pick-Up Address: {DeliveryAddress ?? "N/A"}");
            sb.AppendLine($"Delivery Address: {DropOffAddress ?? "N/A"}");
            sb.AppendLine($"Cost: {Cost:C}");
            sb.AppendLine($"Car: {Car}");
            sb.AppendLine($"Pick-Up Station: {PickUpICarStation.StationName}");
            sb.AppendLine($"Return Station: {DropOffICarStation.StationName}");
            return sb.ToString();
        }

        public void updateRental(RentalStatuses Status)
        {
            RentalStatus = Status;
        }

        // Added a method to check if a date range is available
        public static bool IsDateRangeAvailable(List<Rental> rentals, int rentalId, DateTime newStartDate, DateTime newEndDate)
        {
            foreach (var rental in rentals)
            {
                // Skip the rental with the same ID (since we're modifying it)
                if (rental.RentalId == rentalId)
                    continue;

                // Check for overlap
                if ((newStartDate < rental.EndDate && newEndDate > rental.StartDate))
                {
                    return false;
                }
            }
            return true;
        }

        // Method to calculate additional cost
        private static double CalculateAdditionalCost(DateTime originalEndDate, DateTime newEndDate, double costPerHour)
        {
            // Calculate the duration of the extended rental period
            TimeSpan additionalDuration = newEndDate - originalEndDate;

            // Calculate the additional cost
            double additionalCost = additionalDuration.TotalHours * costPerHour;

            return additionalCost;

           

        }
    }
}
