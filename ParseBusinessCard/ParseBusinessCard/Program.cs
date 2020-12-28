using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseBusinessCard
{
    class Program
    {
        /*
         * Main Class:
         * Ryan Rosiak
         * 1/10/20
         * Entegra Systems Coding Challenge
         * Description:
         * Provides basic UI for inputting a business card string and desired info being
         * returned 
         */
        static void Main(string[] args)
        {
            while (true) // UI loop
            {
                Console.WriteLine("Enter business card string: (Enter -1 to quit)");
                string input = Console.ReadLine();
                if (input == "-1")
                {
                    break;
                }
                BusinessCardParser bc = new BusinessCardParser(); 

                ContactInfo ci = bc.getContactInfo(input);

                Console.WriteLine("Name: " + ci.Name);
                Console.WriteLine("Phone Number: " + ci.PhoneNumber);
                Console.WriteLine("Email Address: " + ci.EmailAddress);
                Console.WriteLine("\n");
            }
        }
    }
}
