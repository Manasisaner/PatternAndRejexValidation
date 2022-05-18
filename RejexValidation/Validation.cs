using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RejexValidation
{
    public class Validation
    {

        public static void Main(string[] args);
        {
        public const string NAME_REGEX = "^[A-Z]{1}[A-Za-z]{3, }$";
        public const string EMAILADDRESS_REGEX = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([azA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        public const string MOBILENUMBER_REGEX = "^[+]{1}[1-9]{2}[-. ]{1}[1-9]{2}[0-9]{8}$";
        public const string EMAILPASSWORD_REGEXX = "[A-Za-z]{8, }$";
        public const string PASSWORDMINIMUMONEUPPERCASE_REGEXX = "[A-Z]{1, }[a-z]{8, }[A-Z]{1, }$";
        public const string PASSWORDMINIMUMONENUMBER_REGEXX = "[A-Z]{1, }[a-z]{8, }[A-Z]{1, }[0-1]{1, }$";
        public const string PASSWORDMINIMUMONE_SPECIALSYMBLE_REGEXX = "[A-Z]{1, }[a-z]{8, }[A-Z]{1, }[0-1]{1, }[!*@#$%^&+=]{1}$";

        }
       
       
        public bool Validate_FirstName(string name)
        {
            if (Regex.IsMatch(name, NAME_REGEX)) ;
            {
                Console.WriteLine("First Name is Valid for the user Account:" + name);
                return true;
            }
        }

    }
}
 
 


