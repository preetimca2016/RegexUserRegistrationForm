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
        public Regex MobileNumberRegex = new Regex(@"^[0-9]{2}\s[0-9]{10}$");
        public Regex PasswordRule1Regex = new Regex(@"^[A-za-z]{8,}$");  //Rule1 minimum 8 Characters 
        
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
        public void ValidateMobileNumber(string MobileNumber)
        {
            Console.WriteLine("\nMobileNumber:" + MobileNumber);
            if (MobileNumberRegex.IsMatch(MobileNumber))
                Console.WriteLine("Valid Mobile Number");
            else
                Console.WriteLine("Invalid Mobile Number");
        }
        public void ValidatePasswordRule1(string PasswordR1)
        {
            Console.WriteLine("\nRule1Password: "+PasswordR1);
            if (PasswordRule1Regex.IsMatch(PasswordR1))
                Console.WriteLine("Valid Password by rule1");
            else
                Console.WriteLine("Invalid Password By rule1");
        }
    }
}
