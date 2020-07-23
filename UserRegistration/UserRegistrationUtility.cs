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

        Regex phoneNumber = new Regex(@"[91]{1} [0-9]{10}");
        public bool validPhoneNumber(string phonenumber)
        {
            return phoneNumber.IsMatch(phonenumber);
        }

        Regex password = new Regex(@"[a-zA-Z0-9]{8}");
        public bool validPassword(string passwordCheck)
        {
            return password.IsMatch(passwordCheck);
        }

        Regex passwordRule2 = new Regex("^([a-z0-9@#!]*)[A-Z]+([a-z0-9@#!]*)$");
        public bool validPasswordRule2(string passwordRule2Check)
        {
            return passwordRule2.IsMatch(passwordRule2Check);
        }

        Regex passwordRule3 = new Regex("^([a-zA-Z@#!]*[0-9]+[a-zA-Z@#!]*)$");
        public bool validPasswordRule3(string passwordRule3Check)
        {
            return passwordRule3.IsMatch(passwordRule3Check);
        }

        Regex passwordRule4 = new Regex("([a-zA-Z0-9]*)[^a-zA-Z_0-9\\s]([a-zA-Z0-9]*)$");
        public bool validPasswordRule4(string passwordRule4Check)
        {
            return passwordRule4.IsMatch(passwordRule4Check);
        }


    }
}
