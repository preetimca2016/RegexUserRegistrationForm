﻿namespace RegexRegistrationForm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegistrationForm userRegexTest = new RegistrationForm();
            string FirstName = "Preeti";
            string LastName = "Sharma";

            userRegexTest.ValidateFirstName(FirstName);
            userRegexTest.ValidateLastName(LastName);
        }   
    }
}