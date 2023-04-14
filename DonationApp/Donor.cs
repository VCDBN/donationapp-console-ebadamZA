using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationApp
{
    internal class Donor
    {

        public Donor(int donorId, string name, string surname, string phone, string email)
        {
            DonorId = donorId;
            Name = name;
            Surname = surname;
            Phone = phone;
            Email = email;
        }

        public int DonorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public string outputObject()
        {
            return DonorId + " - " + Name + " " + Surname + " - " + Phone;
        }
    }
}
