using AgileAddressBook;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
            int phone = 8675309;
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
        /// A test for Address
        ///</summary>
        [TestMethod()]
        public void AddressTest()
        {
            Contact target = new Contact(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Address = expected;
            actual = target.Address;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for City
        ///</summary>
        [TestMethod()]
        public void CityTest()
        {
            Contact target = new Contact(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.City = expected;
            actual = target.City;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FirstName
        ///</summary>
        [TestMethod()]
        public void FirstNameTest()
        {
            Contact target = new Contact(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.FirstName = expected;
            actual = target.FirstName;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        /// A test for the generated FullName
        ///</summary>
        [TestMethod()]
        public void FullNameTest()
        {
            Contact target = new Contact("Butch", "Deadlift");
            Assert.AreEqual("Butch Deadlift", target.FullName);
        }

        /// <summary>
        ///A test for LastName
        ///</summary>
        [TestMethod()]
        public void LastNameTest()
        {
            Contact target = new Contact(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.LastName = expected;
            actual = target.LastName;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Phone
        ///</summary>
        [TestMethod()]
        public void PhoneTest()
        {
            Contact target = new Contact(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.Phone = expected;
            actual = target.Phone;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for State
        ///</summary>
        [TestMethod()]
        public void StateTest()
        {
            Contact target = new Contact(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.State = expected;
            actual = target.State;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Zip
        ///</summary>
        [TestMethod()]
        public void ZipTest()
        {
            Contact target = new Contact(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.Zip = expected;
            actual = target.Zip;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
