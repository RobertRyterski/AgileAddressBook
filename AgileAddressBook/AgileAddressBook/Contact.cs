using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace AgileAddressBook
{
    public class Contact : INotifyPropertyChanged
    {
        // internal fields
        private string _firstName, _lastName, _address, _city, _state;
        private long _phone;
        private int _zip;
        
        // register handler for updating GUI automatically
        public event PropertyChangedEventHandler PropertyChanged;

        // basic properties
        public string FirstName
        {
            get
            {
                return this._firstName;
            }
            set
            {
                this._firstName = value;
                this.OnPropertyChanged("FirstName");
                this.OnPropertyChanged("FullName");
            }
        }

        public string LastName
        {
            get
            {
                return this._lastName;
            }
            set
            {
                this._lastName = value;
                this.OnPropertyChanged("LastName");
                this.OnPropertyChanged("FullName");
            }
        }

        public long Phone
        {
            get
            {
                return this._phone;
            }
            set
            {
                // very bad validation
                if (value > 1000000000 && value <= 9999999999)
                {
                    this._phone = value;
                }
                this.OnPropertyChanged("Phone");
                this.OnPropertyChanged("PhoneAreaCode");
                this.OnPropertyChanged("PhoneOfficeCode");
                this.OnPropertyChanged("PhoneExtension");
                this.OnPropertyChanged("PhoneString");
            }
        }

        public string Address
        {
            get
            {
                return this._address;
            }
            set
            {
                this._address = value;
                this.OnPropertyChanged("Address");
            }
        }

        public string City
        {
            get
            {
                return this._city;
            }
            set
            {
                this._city = value;
                this.OnPropertyChanged("City");
            }
        }

        public string State
        {
            get
            {
                return this._state;
            }
            set
            {
                this._state = value;
                this.OnPropertyChanged("State");
            }
        }

        public int Zip
        {
            get
            {
                return this._zip;
            }
            set
            {
                this._zip = value;
                this.OnPropertyChanged("Zip");
            }
        }

        // generated properties
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public int PhoneAreaCode
        {
            get
            {
                return (int)(Phone / 10000000);
            }
        }

        public int PhoneOffice
        {
            get
            {
                int three = (int)(Phone % 10000000 / 10000);
                return three;
            }
        }

        public int PhoneExtension
        {
            get
            {
                return (int)(Phone % 10000);
            }
        }

        public string PhoneString
        {
            get
            {
                return PhoneAreaCode + "-" + PhoneOffice + "-" + PhoneExtension;
            }
        }

        // constructors
        public Contact()
        {
            // do nothing for now
        }
        
        public Contact(string first, string last)
        {
            _firstName = first;
            _lastName = last;
        }
        
        public Contact(string first, string last, long phone, string address, string city, string state, int zip)
        {
            _firstName = first;
            _lastName = last;
            _phone = phone;
            _address = address;
            _city = city;
            _state = state;
            _zip = zip;
        }

        // returns full name
        public override string ToString()
        {
            return FullName;
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public Contact Clone()
        {
            return new Contact(FirstName, LastName, Phone, Address, City, State, Zip);
        }

        public void Copy(Contact other)
        {
            FirstName = other.FirstName;
            LastName = other.LastName;
            Phone = other.Phone;
            Address = other.Address;
            City = other.City;
            State = other.State;
            Zip = other.Zip;
        }
    }
}
