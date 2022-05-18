namespace RejexValidationTest
{
    internal class Validation
    {
        public bool Validate_FirstName(string name)
        {
            if (Regex.IsMatch(name, NAME_REGEX)) ;
            {
                Console.WriteLine("First Name is Valid for the user Account:" + name);
                return true;
            }
        }
        public bool Validate_LastName(string last)
        {
            if (Regex.IsMatch(last, NAME_REGEX)) ;
            {
                Console.WriteLine("LastName is Valid for the user Account:" + last);
                return true;
            }
        }
         public bool Validate_EmailAddress(string emailAddress)
        {
            if (Regex.IsMatch(emailAddress, EMAILADDRESS_REGEX)) ;
            {
                Console.WriteLine("Password is Valid for the user Account:" + EMAILADDRESS_REGEX);
                return true;
            }
        }
         public bool Validate_MobileNumber(string mobileNumber)
        {
            if (Regex.IsMatch(mobileNumber, MOBILENUMBER_REGEX)) ;
            {
                Console.WriteLine("Email is Valid for the user Account:" + mobileNumber);
                return true;
            }
        }
        public bool Validate_EmailPassword(string emailPassword)
        {
            if (Regex.IsMatch(emailPassword, EMAILADDRESS_REGEX)) ;
            {
                Console.WriteLine("Password is Valid for the user Account:" + emailPassword);
                return true;
            }
        }
        public bool Validate_EmailPassword_AtLeastOneUpperCase(string emailPassword)
        {
            if (Regex.IsMatch(emailPassword, PASSWORDMINIMUMONEUPPERCASE_REGEXX)) ;
            {
                Console.WriteLine("Password is Valid for the user Account:" + emailPassword);
                return true;
            }
        }
    }
}