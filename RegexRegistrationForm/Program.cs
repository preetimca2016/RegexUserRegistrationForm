namespace RegexRegistrationForm
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
            string PasswordR1 = "123asdAeW";//invalid password bcz we given here numeric value and According to syntax required only characters
            string PasswordR2 = "Password";
            //string PasswordR3 = "Password123";
            string PasswordR3 = "Password@123";

            userRegexTest.ValidateFirstName(FirstName);
            userRegexTest.ValidateLastName(LastName);
            userRegexTest.ValidateUserEmail(UserEmail);
            userRegexTest.ValidateMobileNumber(MobileNumber);
            userRegexTest.ValidatePasswordRule1(PasswordR1);
            userRegexTest.ValidatePasswordRule2(PasswordR2);
            userRegexTest.ValidatePasswordRule3(PasswordR3);
        }   

    }
}