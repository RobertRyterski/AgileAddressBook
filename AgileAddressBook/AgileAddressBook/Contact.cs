using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgileAddressBook
{
    public class Contact
    {
        // basic properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }

        // generated properties
        public string FullName
        {
            get
            {
                return "";
            }
        }

        // constructors
        public Contact() { }
        public Contact(string first, string last) { }
        public Contact(string first, string last, long phone, string address, string city, string state, int zip) { }

        // returns full name
        public override string ToString()
        {
            return base.ToString();
        }

        public int GetPhoneAreaCode()
        {
            return 0;
        }

        public int GetPhoneExtension()
        {
            return 0;
        }

        public string EncodePhoneString()
        {
            return string.Empty;
        }
    }
}
