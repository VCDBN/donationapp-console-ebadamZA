using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationApp
{
    internal static class ListUtil
    {
        public static List<Donor> donorList = new List<Donor>();
        public static List<Donation> donations = new List<Donation>();

        public static void PopulateLists()
        {
            Donor d1 = new Donor(1, "John", "Wick", "0800123457", "wick@hollywood.com");
            Donor d2 = new Donor(2, "Chuck", "Norris", "0800123456", "gmail@chuck.com");
            donorList.Add(d1);
            donorList.Add(d2);

            donations.Add(new Donation(0, 100, "SPCA", 1));
            donations.Add(new Donation(1, 1000, "AACL", 1));
            donations.Add(new Donation(2, 2000, "Childline", 2));
        }

        

    }
}
