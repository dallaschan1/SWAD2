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
        private int carOwnerid;

        public int CarOwnerId { get; set; }
        public List<Car> Cars { get; set; } = new List<Car>();

        public CarOwner(string username, string password, string email, string fullName, string phoneNo, int carOwnerid)
            : base(username, password, email, fullName, phoneNo)
        {
        }
    }
}
