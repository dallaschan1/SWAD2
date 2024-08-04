using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Payment
    {
        private string paymentMtd;
        private double totalAmt;

        public string PaymentMtd
        {
            get { return paymentMtd; }
            set { paymentMtd = value; }
        }
        public double TotalAmt
        {
            get { return totalAmt; }
            set { totalAmt = value; }
        }

        public Payment(string paymentMtd, double totalAmt)
        {
            PaymentMtd = paymentMtd;
            TotalAmt = totalAmt;
        }
    }
}
