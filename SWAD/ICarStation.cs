using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAD
{
    internal class ICarStation
    {
        private int stationId;
        private string stationName;
        private string stationAddress;
        public int StationId { get; set; }
        public string StationName { get; set; }
        public string StationAddress { get; set;}
        public ICarStation(int stationId, string stationName, string stationAddress)
        {
            StationId = stationId;
            StationName = stationName;
            StationAddress = stationAddress;
            
        }
    }
    
}
