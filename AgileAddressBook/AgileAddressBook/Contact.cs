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
        public int Phone { get; set; }
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
        public Contact(string first, string last, int phone, string address, string city, string state, int zip) { }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
