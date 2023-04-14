// See https://aka.ms/new-console-template for more information


using DonationApp;
using System.Collections;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        ListUtil.PopulateLists();
        /*
        int[] intArr = new int[10];
        Donor[] donorArray = new Donor[10];

        donorArray[0] = d1;
        donorArray[1] = d2;
        */
        /*
        ArrayList donorArrayList = new ArrayList();
        donorArrayList.Add(d1);
        donorArrayList.Add(d2);
        donorArrayList.Add(55);
        donorArrayList.Add("hello");
        */


        // donorList.Add(55);
        // donorList.Add("hello");

        // TO DO: Place into its own method
        Console.WriteLine("Welcome to the DonorApp!");

        Console.WriteLine("Choose an option:");

        Console.WriteLine("1. Add a donor");
        Console.WriteLine("2. Capture a donation");
        Console.WriteLine("3. Donor Report");
        Console.WriteLine("4. Exit");

        Console.Write("Enter your choice: ");
        int menuChoice = Convert.ToInt32(Console.ReadLine());

        switch (menuChoice)
        {
            case 1:
                AddADonor();
                break;
            case 2:
                CaptureDonation();
                break;
            case 3:
                DonorReport();
                break;
            default:
                break;
        }

        void AddADonor()
        {
            Console.Write("Enter donor name : ");
            string name = Console.ReadLine();

            Console.Write("Enter donor surname: ");
            string surname = Console.ReadLine();

            Console.Write("Enter donor phone: ");
            string phone = Console.ReadLine();

            Console.Write("Enter donor email : ");
            string email = Console.ReadLine();

            Donor donor = new Donor(ListUtil.donorList.Count, name, surname, phone, email);

            ListUtil.donorList.Add(donor);
            Console.WriteLine("Donor Added!");

        }

        void CaptureDonation()
        {
            /*
             * How do we know who the donor is?
             * 1. We get their email
             * 2. Search in the list of donors
             *      For what?? For a donor whose email matches the email provided
             * 3. Once we know which object (donor) it is, we can get the objects donorId :-)
             * 
             */
            Console.Write("Enter donor email: ");
            string email = Console.ReadLine();

            int donorId = SearchByEmail(email);

            Console.Write("Enter donation amount : ");
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter cause: ");
            string cause = Console.ReadLine();

            Donation donation = new Donation(ListUtil.donations.Count, amount, cause, donorId);

            ListUtil.donations.Add(donation);
            Console.WriteLine("Donation Added!");
        }

        void DonorReport()
        {
           
            Console.Write("Enter donor email: ");
            string email = Console.ReadLine();

            int donorId = SearchByEmail(email);

            double total = 0;

            foreach (Donation donation in ListUtil.donations)
            {
                if (donation.DonorId == donorId)
                {
                    Console.WriteLine(donation.Cause + " " + donation.Amount);
                    total += donation.Amount;
                }
            }

            Console.WriteLine("Total is R: " + total);

        }

        int SearchByEmail(string email)
        {
            // Donor result = new Donor(); // Approach 1
            int donorId = 0; // Approach 2
            for (int i = 0; i < ListUtil.donorList.Count; i++)
            {
                if (ListUtil.donorList[i].Email.Equals(email))
                {
                    // result = donorList[i]; // Approach 1
                    donorId = ListUtil.donorList[i].DonorId; // Approach 2
                }
            }
            // int donorID = result.DonorId; // Approach 1

            return donorId;            
        }
    }
}