using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ParseBusinessCard
{
    /*
     * BusinessCardParser Class:
     * Ryan Rosiak
     * 1/10/20
     * Entegra Systems Coding Challenge
     * Description:
     * Allows the user to input a single string equivalent to a business card entry and creates
     * a ContactInfo object to hold the parsed values from the string.
     * This class parses to find the name, phone number, and email from an input string
     */
    class BusinessCardParser
    {
        private ContactInfo rtnMe; // Ojbect to be returned to user once properties are assigned
        private string inputString; // Global input string

        /*
         * getContactInfo Function:
         * Allows the user to pass in a single string that will be parsed for a name, phone
         * number, and email. These elements will be assigned to a ContactInfo object and then 
         * returned to the user
         */
        public ContactInfo getContactInfo(string document)
        {
            inputString = document;
            rtnMe = new ContactInfo();
            rtnMe.Name = parseName();
            rtnMe.PhoneNumber = parsePhoneNumber();
            rtnMe.EmailAddress = parseEmailAddress();
            return rtnMe;
        }

        /*
         * parseName Function:
         * No parameters. Uses the inputString assigned from getContactInfo and regular 
         * expressions in order to parse a specific name from the input string.
         * The matches are displayed to the user to choose from to disambiguate human names, and 
         * company names as such. 
         * Once chosen, the function returns the chosen string to the getContactInfo function
         * to be assigned.
         */
        private string parseName()
        {
            string pattern = @"[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*";
            Regex rg = new Regex(pattern);
            MatchCollection m;
            try
            {
                m = rg.Matches(inputString);
                for (int i = 0; i < m.Count; i++) // Display matches on screen to user
                {
                    Console.WriteLine("{0}. {1}", i + 1, m[i].Groups[0].Value);
                }
                Console.WriteLine("Which of these is the name? (Enter single digit input)");
                string input = Console.ReadLine();
                int answer = 1;
                bool success = int.TryParse(input, out answer);
                if (success) {
                    return m[answer - 1].Value;
                }
            }
            catch (ArgumentOutOfRangeException)
            {

            }
            return "Name not found"; // If nothing can be parsed
        }
        
        /*
         * parsePhoneNumber Function:
         * No parameters. Uses the inputString assigned from getContactInfo and regular
         * expressions in order to parse a phone number from the input string.
         * Once found, the special characters are stripped and replaced with blank space to create
         * a new string filled with digits only.
         * This function returns the edited string to the getContactInfo function to be assigned.
         */
        private string parsePhoneNumber()
        {
            string pattern = @"\s*(?:\+?(\d{1,3}))?[-. (]*(\d{3})[-. )]*(\d{3})[-. ]*(\d{4})(?: *x(\d+))?\s*";
            Regex rg = new Regex(pattern);
            MatchCollection m;
            try
            {
                m = rg.Matches(inputString);
                string newStr = Regex.Replace(m[0].Value, @"(\s+|@|&|'|\(|\)|<|>|-|\+|#)", ""); // Delete special characters from phone number
                return newStr;
            }
            catch (ArgumentOutOfRangeException)
            {

            }
            return "Phone Number not found"; // If nothing can be parsed
        }

        /*
         * parseEmailAddress Function:
         * No parameters. Uses the inputString assigned from getContactInfo and regular
         * expressions in order to parse an email address from the input string.
         * Once found, this function returns the found email address string to the getContactInfo
         * function to be assigned.
         */
        private string parseEmailAddress()
        {
            string pattern = @"[a-zA-Z0-9+._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z0-9_-]+";
            Regex rg = new Regex(pattern);
            MatchCollection m;
            try
            {
                m = rg.Matches(inputString);
                return m[0].Value;
            } 
            catch (ArgumentOutOfRangeException)
            {

            }
            return "Email not found"; // If nothing can be parsed
        }
    }
}
