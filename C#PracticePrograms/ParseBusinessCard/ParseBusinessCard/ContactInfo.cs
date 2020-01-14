using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseBusinessCard
{
    /*
     * ContactInfo Class:
     * Ryan Rosiak
     * 1/10/20
     * Entegra Systems Coding Challenge
     * Description:
     * Class that represents instances of various contacts on a phone. 
     * Holds basic info of contacts:
     * - Name
     * - Phone Number
     * - Email Address
     */
    class ContactInfo
    {
        // Encapsulation
        private string name;
        private string phoneNumber;
        private string emailAddress;

        // Initialize member variables 
        public ContactInfo()
        {
            this.name = "";
            this.phoneNumber = "";
            this.emailAddress = "";
        }

        // Properties are made so that future ContactInfo class methods can be made 
        // and allow easy access to private members
        public string Name { get { return name; } set { name = value; } }
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public string EmailAddress { get { return emailAddress; } set { emailAddress = value; } }
    }
}
