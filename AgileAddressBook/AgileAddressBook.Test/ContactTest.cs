using AgileAddressBook;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AgileAddressBook.Test
{
    
    
    /// <summary>
    ///This is a test class for ContactTest and is intended
    ///to contain all ContactTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ContactTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
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

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Contact Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("AgileAddressBook.exe")]
        public void ContactConstructorTest()
        {
            string first = string.Empty; // TODO: Initialize to an appropriate value
            string last = string.Empty; // TODO: Initialize to an appropriate value
            int phone = 0; // TODO: Initialize to an appropriate value
            string address = string.Empty; // TODO: Initialize to an appropriate value
            string city = string.Empty; // TODO: Initialize to an appropriate value
            string state = string.Empty; // TODO: Initialize to an appropriate value
            int zip = 0; // TODO: Initialize to an appropriate value
            Contact_Accessor target = new Contact_Accessor(first, last, phone, address, city, state, zip);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Contact Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("AgileAddressBook.exe")]
        public void ContactConstructorTest1()
        {
            string first = string.Empty; // TODO: Initialize to an appropriate value
            string last = string.Empty; // TODO: Initialize to an appropriate value
            Contact_Accessor target = new Contact_Accessor(first, last);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Contact Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("AgileAddressBook.exe")]
        public void ContactConstructorTest2()
        {
            Contact_Accessor target = new Contact_Accessor();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ToString
        ///</summary>
        [TestMethod()]
        [DeploymentItem("AgileAddressBook.exe")]
        public void ToStringTest()
        {
            Contact_Accessor target = new Contact_Accessor(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Address
        ///</summary>
        [TestMethod()]
        [DeploymentItem("AgileAddressBook.exe")]
        public void AddressTest()
        {
            Contact_Accessor target = new Contact_Accessor(); // TODO: Initialize to an appropriate value
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
        [DeploymentItem("AgileAddressBook.exe")]
        public void CityTest()
        {
            Contact_Accessor target = new Contact_Accessor(); // TODO: Initialize to an appropriate value
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
        [DeploymentItem("AgileAddressBook.exe")]
        public void FirstNameTest()
        {
            Contact_Accessor target = new Contact_Accessor(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.FirstName = expected;
            actual = target.FirstName;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FullName
        ///</summary>
        [TestMethod()]
        [DeploymentItem("AgileAddressBook.exe")]
        public void FullNameTest()
        {
            Contact_Accessor target = new Contact_Accessor(); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.FullName;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LastName
        ///</summary>
        [TestMethod()]
        [DeploymentItem("AgileAddressBook.exe")]
        public void LastNameTest()
        {
            Contact_Accessor target = new Contact_Accessor(); // TODO: Initialize to an appropriate value
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
        [DeploymentItem("AgileAddressBook.exe")]
        public void PhoneTest()
        {
            Contact_Accessor target = new Contact_Accessor(); // TODO: Initialize to an appropriate value
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
        [DeploymentItem("AgileAddressBook.exe")]
        public void StateTest()
        {
            Contact_Accessor target = new Contact_Accessor(); // TODO: Initialize to an appropriate value
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
        [DeploymentItem("AgileAddressBook.exe")]
        public void ZipTest()
        {
            Contact_Accessor target = new Contact_Accessor(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.Zip = expected;
            actual = target.Zip;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
