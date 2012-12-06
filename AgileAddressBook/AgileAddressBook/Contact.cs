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
                return FirstName + " " + LastName;
            }
        }

        // constructors
        public Contact()
        {
            // do nothing for now
        }
        
        public Contact(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }
        
        public Contact(string first, string last, long phone, string address, string city, string state, int zip)
        {
            FirstName = first;
            LastName = last;
            Phone = phone;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
        }

        // returns full name
        public override string ToString()
        {
            return FullName;
        }

        public int GetPhoneAreaCode()
        {
            return (int)(Phone / 10000000);
        }

        public int GetPhoneExtension()
        {
            return (int)(Phone % 10000000);
        }

        public string EncodePhoneString()
        {
            int three = (int)(GetPhoneExtension() / 10000);
            int four = (int)(GetPhoneExtension() % 10000);
            return GetPhoneAreaCode() + "-" + three + "-" + four;
        }
    }
}
