using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class TimeSlots
    {
        private DateTime date;
        private Boolean availability;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public Boolean Availability
        {
            get { return availability; }
            set { availability = value; }

        }

        public TimeSlots(DateTime Date, Boolean Availability) 
        { 
            this.Date = Date;
            this.Availability = Availability;
        }
    }
}
