using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {       
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create

            clsCustomer Customer = new clsCustomer();

            //test to see that it exists
            Assert.IsNotNull(Customer);

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
        public void CustomerFullNamePropertyOK()
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
        public void CustomerPhoneNumberPropertyOK()
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
        public void CustomerBillingAddressPropertyOK()
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

        [TestMethod]
        public void DateOfRegistrationPropertyOK()
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
           

            String Error = "";

       //     Error = Customer.IsAllowed(customerId, description, quantity, supplierid, expirydate, price);

            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void FindMethodOK()
        {
        
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //test to see if the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check customer number
            if (ACustomer.CustomerId != 1)
            {
               OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerFullNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the property
            if (ACustomer.CustomerFullName != "Joe Bloggs")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerPhoneNumberFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the property
            if (ACustomer.CustomerPhoneNumber != "01858100100")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerBillingAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the property
            if (ACustomer.CustomerBillingAddress != "1 DMU Close")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void TestIsAllowedFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the property
            if (ACustomer.IsAllowed != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestDateOfRegistrationFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the property
            if (ACustomer.DateOfRegistration != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

    }
}

