using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        //private data member for the customer no property
        private Int32 mCustomerId;
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create

            clsCustomer Customer = new clsCustomer();

            //test to see that it exists
            Assert.IsNotNull(Customer);

        }

        [TestMethod]

        public void IsAllowedPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //create some test data
            Boolean TestData = true;
            //assign the data to the property
            Customer.IsAllowed = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(Customer.IsAllowed, TestData);

        }

        [TestMethod]
        public void RegistrationDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            Customer.DateOfRegistration = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Customer.DateOfRegistration, TestData);
        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            Customer.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Customer.CustomerId, TestData);
        }


        [TestMethod]
        public void FullNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //create some test data to assign the property
            string TestData = "Jane Doe";
            //assign the data to the property
            Customer.CustomerFullName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Customer.CustomerFullName, TestData);
        }


        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //create some test data to assign the property
            string TestData = "01858100100";
            //assign the test data to the property 
            Customer.CustomerPhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Customer.CustomerPhoneNumber, TestData);
        }


        [TestMethod]
        public void BillingAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "10 DMU Road";
            //assign the data to the property
            Customer.CustomerBillingAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Customer.CustomerBillingAddress, TestData);
        }

        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 200503;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //test to see if the result is true
            Assert.IsTrue(Found);
            //check customer number
            if (ACustomer.CustomerId != 200503)
            {
               OK = false;
            }

            Assert.IsTrue(OK);
        }
    }
}

