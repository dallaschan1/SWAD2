using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Insurance
    {
        private string policyNumber;
        private string policyHolderName;
        private string issuedBy;
        private DateTime startDate;
        private DateTime endDate;
        private string policyStatus;
        private double coverageAmount;
        private string insuranceCompanyEmail;
        private string insuranceCompanyNumber;
        public string PolicyNumber { get; set; }
        public string PolicyHolderName { get; set; }
        public string IssuedBy { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PolicyStatus { get; set; }
        public double CoverageAmount { get; set; }
        public string InsuranceCompanyEmail { get; set; }
        public string InsuranceCompanyNumber { get; set; }
        public Insurance() { }
        public Insurance(string policyNumber, string policyHolderName, string issuedBy, DateTime startDate, DateTime endDate, string policyStatus, double coverageAmount, string insuranceCompanyEmail, string insuranceCompanyNumber)
        {
            PolicyNumber = policyNumber;
            PolicyHolderName = policyHolderName;
            IssuedBy = issuedBy;
            StartDate = startDate;
            EndDate = endDate;
            PolicyStatus = policyStatus;
            CoverageAmount = coverageAmount;
            InsuranceCompanyEmail = insuranceCompanyEmail;
            InsuranceCompanyNumber = insuranceCompanyNumber;
        }
    }

}
