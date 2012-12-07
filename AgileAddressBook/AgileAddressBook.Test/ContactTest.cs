using AgileAddressBook;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel;

namespace AgileAddressBook.Test
{    
    /// <summary>
    /// ContactTest contains all the unit tests for the Contact class.
    ///</summary>
    [TestClass()]
    public class ContactTest
    {
        private TestContext testContextInstance;

        /// <summary>
        /// Gets or sets the test context which provides information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        /// <summary>
        /// A test for the Contact constructor with all the arguments.
        ///</summary>
        [TestMethod()]
        public void ContactConstructorAllArgumentsTest()
        {
            string first = "Slab";
            string last = "Bulkhead";
            long phone = 5558675309;
            string address = "123 Fake Street";
            string city = "Faketon";
            string state = "MO";
            int zip = 123123;
            Contact target = new Contact(first, last, phone, address, city, state, zip);
            Assert.AreEqual(first, target.FirstName);
            Assert.AreEqual(last, target.LastName);
            Assert.AreEqual(phone, target.Phone);
            Assert.AreEqual(address, target.Address);
            Assert.AreEqual(city, target.City);
            Assert.AreEqual(state, target.State);
            Assert.AreEqual(zip, target.Zip);
        }

        /// <summary>
        /// A test for the Contact constructor with only the name arguments.
        ///</summary>
        [TestMethod()]
        public void ContactConstructorNameArgumentsTest()
        {
            string first = "Fridge";
            string last = "Largemeat";
            Contact target = new Contact(first, last);
            Assert.AreEqual(first, target.FirstName);
            Assert.AreEqual(last, target.LastName);
            // default values
            Assert.AreEqual(0, target.Phone);
            Assert.IsNull(target.Address);
            Assert.IsNull(target.City);
            Assert.IsNull(target.State);
            Assert.AreEqual(0, target.Zip);
        }

        /// <summary>
        /// A test for the Contact constructor without any arguments.
        ///</summary>
        [TestMethod()]
        public void ContactConstructorNoArgumentsTest()
        {
            Contact target = new Contact();
            // default values
            Assert.IsNull(target.FirstName);
            Assert.IsNull(target.LastName);            
            Assert.AreEqual(0, target.Phone);
            Assert.IsNull(target.Address);
            Assert.IsNull(target.City);
            Assert.IsNull(target.State);
            Assert.AreEqual(0, target.Zip);
        }

        /// <summary>
        /// A test for ToString.
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            Contact target = new Contact("Punt", "Speedchunk");
            // ToString should just join the name
            string expected = "Punt Speedchunk";
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for the generated FullName.
        ///</summary>
        [TestMethod()]
        public void FullNameTest()
        {
            Contact target = new Contact("Butch", "Deadlift");
            Assert.AreEqual("Butch Deadlift", target.FullName);
        }

        /// <summary>
        /// A test for PhoneAreaCode.
        ///</summary>
        [TestMethod()]
        public void PhoneAreaCodeTest()
        {
            Contact target = new Contact();
            target.Phone = 5558675309;
            int expected = 555;
            int actual = target.PhoneAreaCode;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for PhoneOffice.
        ///</summary>
        [TestMethod()]
        public void PhoneOfficeTest()
        {
            Contact target = new Contact();
            target.Phone = 5558675309;
            int expected = 867;
            int actual = target.PhoneOffice;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for PhoneExtension.
        ///</summary>
        [TestMethod()]
        public void PhoneExtensionTest()
        {
            Contact target = new Contact();
            target.Phone = 5558675309;
            int expected = 5309;
            int actual = target.PhoneExtension;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for EncodePhoneString.
        ///</summary>
        [TestMethod()]
        public void PhoneStringTest()
        {
            Contact target = new Contact();
            target.Phone = 5558675309;
            string expected = "555-867-5309";
            string actual = target.PhoneString;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for Clone.
        ///</summary>
        [TestMethod()]
        public void CloneTest()
        {
            string first = "Bold";
            string last = "Bigflank";
            long phone = 5558675309;
            string address = "123 Fake Street";
            string city = "Faketon";
            string state = "MO";
            int zip = 123123;
            Contact original = new Contact(first, last, phone, address, city, state, zip);
            Contact target = original.Clone();
            Assert.AreEqual(first, target.FirstName);
            Assert.AreEqual(last, target.LastName);
            Assert.AreEqual(phone, target.Phone);
            Assert.AreEqual(address, target.Address);
            Assert.AreEqual(city, target.City);
            Assert.AreEqual(state, target.State);
            Assert.AreEqual(zip, target.Zip);
        }

        /// <summary>
        /// A test for Copy.
        ///</summary>
        [TestMethod()]
        public void CopyTest()
        {
            string first = "Flint";
            string last = "Ironstag";
            long phone = 5558675309;
            string address = "123 Fake Street";
            string city = "Faketon";
            string state = "MO";
            int zip = 123123;
            Contact original = new Contact(first, last, phone, address, city, state, zip);
            Contact target = original.Clone();
            Assert.AreEqual(first, target.FirstName);
            Assert.AreEqual(last, target.LastName);
            Assert.AreEqual(phone, target.Phone);
            Assert.AreEqual(address, target.Address);
            Assert.AreEqual(city, target.City);
            Assert.AreEqual(state, target.State);
            Assert.AreEqual(zip, target.Zip);
        }

        /// <summary>
        /// A test to see that the GUI is notified via INotifyPropertyChanged when FirstName is modified.
        ///</summary>
        [TestMethod()]
        public void FirstNameNotifyTest()
        {
            // based on http://www.benday.com/2010/08/24/an-easier-way-to-unit-test-inotifypropertychanged-in-silverlightwpf/
            Contact target = new Contact("Bolt", "Vanderhuge");
            bool firstNameChanged = false;
            bool fullNameChanged = false;
            ((INotifyPropertyChanged)target).PropertyChanged +=
                delegate(object sender, PropertyChangedEventArgs e)
                {
                    firstNameChanged = firstNameChanged || e.PropertyName == "FirstName";
                    fullNameChanged = fullNameChanged || e.PropertyName == "FullName";
                };

            var newValue = "Lightning";
            target.FirstName = newValue;
            Assert.AreEqual(newValue, target.FirstName);
            Assert.IsTrue(firstNameChanged, "FirstName not seen in delegate.");
            Assert.IsTrue(fullNameChanged, "FullName not seen in delegate.");
        }

        /// <summary>
        /// A test to see that the GUI is notified via INotifyPropertyChanged when LastName is modified.
        ///</summary>
        [TestMethod()]
        public void LastNameNotifyTest()
        {
            // based on http://www.benday.com/2010/08/24/an-easier-way-to-unit-test-inotifypropertychanged-in-silverlightwpf/
            Contact target = new Contact("Blast", "Hardcheese");
            bool lastNameChanged = false;
            bool fullNameChanged = false;
            ((INotifyPropertyChanged)target).PropertyChanged +=
                delegate(object sender, PropertyChangedEventArgs e)
                {
                    lastNameChanged = lastNameChanged || e.PropertyName == "LastName";
                    fullNameChanged = fullNameChanged || e.PropertyName == "FullName";
                };

            var newValue = "Softcheese";
            target.LastName = newValue;
            Assert.AreEqual(newValue, target.LastName);
            Assert.IsTrue(lastNameChanged, "LastName not seen in delegate.");
            Assert.IsTrue(fullNameChanged, "FullName not seen in delegate.");
        }

        /// <summary>
        /// A test to see that the GUI is notified via INotifyPropertyChanged when Phone is modified.
        ///</summary>
        [TestMethod()]
        public void PhoneNotifyTest()
        {
            // based on http://www.benday.com/2010/08/24/an-easier-way-to-unit-test-inotifypropertychanged-in-silverlightwpf/
            Contact target = new Contact();
            bool changed = false;
            ((INotifyPropertyChanged)target).PropertyChanged +=
                delegate(object sender, PropertyChangedEventArgs e)
                {
                    changed = e.PropertyName == "Phone";
                };

            var newValue = 5558675309;
            target.Phone = newValue;
            Assert.AreEqual(newValue, target.Phone);
            Assert.IsTrue(changed, "FirstName not seen in delegate.");
        }

        /// <summary>
        /// A test to see that the GUI is notified via INotifyPropertyChanged when Address is modified.
        ///</summary>
        [TestMethod()]
        public void AddressNotifyTest()
        {
            // based on http://www.benday.com/2010/08/24/an-easier-way-to-unit-test-inotifypropertychanged-in-silverlightwpf/
            Contact target = new Contact();
            bool changed = false;
            ((INotifyPropertyChanged)target).PropertyChanged +=
                delegate(object sender, PropertyChangedEventArgs e)
                {
                    changed = e.PropertyName == "Address";
                };

            var newValue = "123 Fake St";
            target.Address = newValue;
            Assert.AreEqual(newValue, target.Address);
            Assert.IsTrue(changed, "Address not seen in delegate.");
        }

        /// <summary>
        /// A test to see that the GUI is notified via INotifyPropertyChanged when City is modified.
        ///</summary>
        [TestMethod()]
        public void CityNotifyTest()
        {
            // based on http://www.benday.com/2010/08/24/an-easier-way-to-unit-test-inotifypropertychanged-in-silverlightwpf/
            Contact target = new Contact();
            bool changed = false;
            ((INotifyPropertyChanged)target).PropertyChanged +=
                delegate(object sender, PropertyChangedEventArgs e)
                {
                    changed = e.PropertyName == "City";
                };

            var newValue = "Albuquerque";
            target.City = newValue;
            Assert.AreEqual(newValue, target.City);
            Assert.IsTrue(changed, "City not seen in delegate.");
        }

        /// <summary>
        /// A test to see that the GUI is notified via INotifyPropertyChanged when State is modified.
        ///</summary>
        [TestMethod()]
        public void StateNotifyTest()
        {
            // based on http://www.benday.com/2010/08/24/an-easier-way-to-unit-test-inotifypropertychanged-in-silverlightwpf/
            Contact target = new Contact();
            bool changed = false;
            ((INotifyPropertyChanged)target).PropertyChanged +=
                delegate(object sender, PropertyChangedEventArgs e)
                {
                    changed = e.PropertyName == "State";
                };

            var newValue = "MO";
            target.State = newValue;
            Assert.AreEqual(newValue, target.State);
            Assert.IsTrue(changed, "State not seen in delegate.");
        }

        /// <summary>
        /// A test to see that the GUI is notified via INotifyPropertyChanged when Zip is modified.
        ///</summary>
        [TestMethod()]
        public void ZipNotifyTest()
        {
            // based on http://www.benday.com/2010/08/24/an-easier-way-to-unit-test-inotifypropertychanged-in-silverlightwpf/
            Contact target = new Contact();
            bool changed = false;
            ((INotifyPropertyChanged)target).PropertyChanged +=
                delegate(object sender, PropertyChangedEventArgs e)
                {
                    changed = e.PropertyName == "Zip";
                };

            var newValue = 123123;
            target.Zip = newValue;
            Assert.AreEqual(newValue, target.Zip);
            Assert.IsTrue(changed, "Zip not seen in delegate.");
        }        
    }
}
