using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Accident
    {
        private DateTime timeOfAccident;
        private string descriptionOfAccident;
        

        public DateTime TimeOfAccident
        {
            get { return timeOfAccident; }
            set { timeOfAccident = value; }
        }
        public string DescriptionOfAccident
        {
            get { return descriptionOfAccident; }
            set { descriptionOfAccident = value; }
        }
        

        public Accident(DateTime timeOfAccident, string descriptionOfAccident)
        {
            TimeOfAccident = timeOfAccident;
            DescriptionOfAccident = descriptionOfAccident;
            
        }
    }
}