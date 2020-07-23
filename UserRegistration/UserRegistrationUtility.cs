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
    }
}
