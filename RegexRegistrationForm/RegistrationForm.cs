using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexRegistrationForm
{
    class RegistrationForm
    {
        //string FirstName = @"^[A-Z][a-zA-Z]{2,}$";
        public Regex FirstnameRegex = new Regex(@"^[A-Z][a-zA-Z]{2,}$");
        public Regex LastNameRegex = new Regex(@"^[A-Z][a-zA-Z]{2,}$");
        public Regex UserEmailRegex = new Regex(@"^[A-Z a-z 0-9]+([.-_+][A-Z a-z 0-9]+)*@[A-Z a-z 0-9]+.[A-Z a-z]{2,4}([.][A-Z a-z]{2,})?$");

        public void ValidateFirstName(string FirstName)
        {
            Console.WriteLine("\nfirst name: "+FirstName);
            if (FirstnameRegex.IsMatch(FirstName))

                Console.WriteLine("valid First Name");
            else
                Console.WriteLine("Invalid FirstName");
        }
        public void ValidateLastName(string LastName)
        {
            Console.WriteLine("\nLast name: " + LastName);
            if (LastNameRegex.IsMatch(LastName))
                Console.WriteLine("valid last Name");
            else
                Console.WriteLine("Invalid lastName");
        }
        public void ValidateUserEmail(string UserEmail)
        {
            Console.WriteLine("\nEmail ID: " + UserEmail);
            if (UserEmailRegex.IsMatch(UserEmail))
                Console.WriteLine("Valid Email ID");
            else
                Console.WriteLine("Invalid Email ID");

        }
    }
}
