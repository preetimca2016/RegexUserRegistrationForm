﻿using System;
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
       
        public void ValidateFirstName(string FirstName)
        {
            Console.WriteLine("\nfirst name: "+FirstName);
            if (FirstnameRegex.IsMatch(FirstName))

                Console.WriteLine("valid First Name");
            else
                Console.WriteLine("Invalid FirstName");
        }       
    }
}
