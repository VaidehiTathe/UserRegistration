using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserRegistrationUtility
    {
        Regex firstName = new Regex(@"[A-Z]{1}[a-z]{2,}");

        public bool validFirstName(string fname)
        {
            return firstName.IsMatch(fname);
        }

        Regex lastName = new Regex(@"[A-Z]{1}[a-z]{2,}");
        public bool validLastName(string lname)
        {
            return lastName.IsMatch(lname);
        }

        Regex emailID = new Regex("^[0-9a-zA-Z]+([._+-][0-9a-zA-Z]+)*@[0-9a-zA-Z]+.[a-zA-Z]{2,4}(.[a-zA-Z]{2,2})*$");

        public bool validEmail(string email)
        {
            return emailID.IsMatch(email);
        }
    }
}
