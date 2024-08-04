using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class VehicleInspection
    {
        private DateTime inspectionDate;
        private string inspectionStatus;
        private string inspectionDetail;

        public DateTime InspectionDate { get {  return inspectionDate; } set {  inspectionDate = value; } }
        public string InspectionStatus { get {  return inspectionStatus; } set {  InspectionStatus = value; } }
        public string InspectionDetail { get {  return inspectionDetail; } set {  InspectionDetail = value; } }

        public VehicleInspection(DateTime inspectionDate, string inspectionStatus, string inspectionDetail ) 
        {
            InspectionDate = inspectionDate;
            InspectionStatus = inspectionStatus;
            InspectionDetail = inspectionDetail;
        }

    }
}
