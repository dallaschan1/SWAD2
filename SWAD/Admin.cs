using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Admin : Account
    {
        private int adminId;

        public int AdminId
        {
            get { return adminId; }
            set { adminId = value; }
        }

        public Admin(string username, string password, string email, string fullName, string phoneNo, int adminId): base(username, password, email, fullName, phoneNo)
        {
            AdminId = adminId;
        }
    }
}
