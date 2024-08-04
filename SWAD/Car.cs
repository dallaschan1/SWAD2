using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Car
    {
        private int vehicleId;
        private string type;
        private string make;
        private string model;
        private int year;
        private List<string> photoUrls;
        private int mileage;
        private string fuelType;
        private string licensePlate;
        private double rentalRate;
        private Insurance? insurance;
        private List<TimeSlots> timeSlots = new List<TimeSlots>();

        public int VehicleId
        {
            get { return vehicleId; }
            set { vehicleId = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public List<string> PhotoUrls
        {
            get { return photoUrls; }
            set { photoUrls = value; }
        }
        public int Mileage
        {
            get { return mileage; }
            set { mileage = value; }
        }
        public string FuelType
        {
            get { return fuelType; }
            set { fuelType = value; }
        }
        public string LicensePlate
        {
            get { return licensePlate; }
            set { licensePlate = value; }
        }
        public double RentalRate
        {
            get { return rentalRate; }
            set { rentalRate = value; }
        }
        public Insurance? Insurance
        {
            get { return insurance; }
            set { insurance = value; }
        }
        public List<TimeSlots> TimeSlots
        {
            get { return timeSlots; }
            
        }

        public Car(int vehicleId, string type, string make, string model, int year, List<string> photoUrls, int mileage, string fuelType, string licensePlate, double rentalRate)
        {
            VehicleId = vehicleId;
            Type = type;
            Make = make;
            Model = model;
            Year = year;
            PhotoUrls = photoUrls;
            Mileage = mileage;
            FuelType = fuelType;
            LicensePlate = licensePlate;
            RentalRate = rentalRate;
            
        }
        // Method to check if insurance exists for this car
        public bool FindInsurance()
        {
            return Insurance != null;
        }
        // Method to update vehicle details
        public void UpdateVehicleDetails(string type, string make, string model, int year, List<string> photoUrls, int mileage, string fuelType, string licensePlate)
        {
            Type = type;
            Make = make;
            Model = model;
            Year = year;
            PhotoUrls = photoUrls;
            Mileage = mileage;
            FuelType = fuelType;
            LicensePlate = licensePlate;
        }
    }
}
