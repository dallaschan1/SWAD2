using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class TimeSlots
    {
        private DateOnly date;
        private Boolean availability;

        public DateOnly Date
        {
            get { return date; }
            set { date = value; }
        }

        public Boolean Availability
        {
            get { return availability; }
            set { availability = value; }

        }

        public TimeSlots(DateOnly Date, Boolean Availability) 
        { 
            this.Date = Date;
            this.Availability = Availability;
        }

        public void updateAvailability(Boolean Availability)
        {
            this.Availability = Availability;
        }


    }
}
