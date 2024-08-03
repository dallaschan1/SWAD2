using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAD
{
    internal class Accident
    {
        private DateTime timeOfAccident;
        private string descriptionOfAccident;

        public DateTime TimeOfAccident { get; set; } = DateTime.Now;
        public string DescriptionOfAccident { get; set; }

        public Accident(DateTime timeOfAccident, string descriptionOfAccident)
        {
            TimeOfAccident = timeOfAccident;
            DescriptionOfAccident = descriptionOfAccident;
        }
    }
}
