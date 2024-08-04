using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_RegisterAcc
{
    internal class Admin : Account
    {
        private int adminId;

        public int AdminId;

        public Admin(int adminId)
        {
            AdminId = adminId;
        }
    }
}
