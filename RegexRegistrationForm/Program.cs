﻿namespace RegexRegistrationForm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegistrationForm userRegexTest = new RegistrationForm();
            string FirstName = "Preeti";
            string LastName = "Sharma";
            string UserEmail = "preetimca2016@gmail.com";
            string MobileNumber = "91 1234567890";

            userRegexTest.ValidateFirstName(FirstName);
            userRegexTest.ValidateLastName(LastName);
            userRegexTest.ValidateUserEmail(UserEmail);
            userRegexTest.ValidateMobileNumber(MobileNumber);
        }   
    }
}