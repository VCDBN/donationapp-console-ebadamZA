using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationApp
{
    internal class Donation
    {
        public Donation(int donationId, double amount, string cause, int donorId)
        {
            DonationId = donationId;
            Amount = amount;
            Cause = cause;
            DonorId = donorId;
        }

        public int DonationId { get; set; }
        public double Amount { get; set; }
        public string Cause { get; set; }
        public int DonorId { get; set; }
    }
}
