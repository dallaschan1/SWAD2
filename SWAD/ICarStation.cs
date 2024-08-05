using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class ICarStation
    {
        private int stationId;
        private string stationAddress;
        private string stationName;
        private List<Car> cars = new List<Car>();

        public int StationId
        {
            get { return stationId; }
            set { stationId = value; }
        }
        public string StationName
        {
            get { return stationName; }
            set { stationName = value; }
        }
        public string StationAddress
        {
            get { return stationAddress; }
            set { stationAddress = value; }
        }
        public List<Car> Cars
        {
            get { return cars; }
        }
        public ICarStation()
        {

        }
        public ICarStation(int stationId, string stationAddress, string stationName)
        {
            StationId = stationId;
            StationAddress = stationAddress;
            StationName = stationName;
            
        }

        public void AddCar(Car car)
        {
            cars.Add(car);
        }


        public Boolean checkCarInICarStation(Car aCar)
        {
            return cars.Contains(aCar);
        }
    }
}
