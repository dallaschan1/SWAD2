using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class CarOwner : Account
    {
        private int carOwnerId;
        private List<Car> cars = new List<Car>();

        public int CarOwnerId
        {
            get { return carOwnerId; }
            set { carOwnerId = value; }
        }
        public List<Car> Cars
        {
            get { return cars; }
            set { cars = value; }
         
        }

        public CarOwner(string username, string password, string email, string fullName, string phoneNo, int carOwnerId)
            : base(username, password, email, fullName, phoneNo)
        {
            CarOwnerId = carOwnerId;
        }

    }
}
