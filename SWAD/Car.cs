namespace SWAD
{
    internal class Car
    {
        private string vehicleId;

        private string type;

        private string make;

        private string model;

        private string year;

        private List<String> photoUrls;

        private int mileage;

        private string fuelType;

        private string licensePlate;

        private double rentalRate;

        public string VehicleId { get; set; }

        public string Type { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public List<string> PhotoUrls { get; set; }

        public int Mileage { get; set; }

        public string FuelType { get; set; }

        public string LicensePlate { get; set; }

        public double RentalRate { get; set; }

        // Constructor
        public Car(string vehicleId, string type, string make, string model, int year, List<string> photoUrls, int mileage, string fuelType, string licensePlate, double rentalRate)
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
    }
}
