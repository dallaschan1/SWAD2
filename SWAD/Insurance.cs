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

        public string PolicyNumber
        {
            get { return policyNumber; }
            set { policyNumber = value; }
        }
        public string PolicyHolderName
        {
            get { return policyHolderName; }
            set { policyHolderName = value; }
        }
        public string IssuedBy
        {
            get { return issuedBy; }
            set { issuedBy = value; }
        }
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        public string PolicyStatus
        {
            get { return policyStatus; }
            set { policyStatus = value; }
        }
        public double CoverageAmount
        {
            get { return coverageAmount; }
            set { coverageAmount = value; }
        }
        public string InsuranceCompanyEmail
        {
            get { return insuranceCompanyEmail; }
            set { insuranceCompanyEmail = value; }
        }
        public string InsuranceCompanyNumber
        {
            get { return insuranceCompanyNumber; }
            set { insuranceCompanyNumber = value; }
        }

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
