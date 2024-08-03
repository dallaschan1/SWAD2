using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAD
{
    internal class Payment
    {
        private string paymentMtd;
        private double totalAmt;

        public string PaymentMtd { get; set; }
        public double TotalAmt { get; set; }

        public Payment(string paymentMtd, double totalAmt)
        {
            PaymentMtd = paymentMtd;
            TotalAmt = totalAmt;
        }
    }
}
