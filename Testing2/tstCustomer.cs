using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {

        //Good test data
        string CustomerFullName = "some name";
        string CustomerPhoneNumber = "01858123456";
        string CustomerBillingAddress = "1 dmu close";
        string DateOfRegistration = DateTime.Now.Date.ToString();

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
            if (ACustomer.CustomerPhoneNumber != "01858910635")
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
            if (ACustomer.CustomerBillingAddress != "13 Chase Road")
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
            if (ACustomer.DateOfRegistration != Convert.ToDateTime("21/02/2023"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerBillingAddress, DateOfRegistration);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        //Customer full name validity
        [TestMethod]
        public void CustomerFullNameMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerFullName = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerBillingAddress, DateOfRegistration);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CustomerFullNameMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerFullName = "a"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerBillingAddress, DateOfRegistration);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerFullNameMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerFullName = "aa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerBillingAddress, DateOfRegistration);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerFullNameMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerFullName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerBillingAddress, DateOfRegistration);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerFullNameMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerFullName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerBillingAddress, DateOfRegistration);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CustomerFullNameMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerFullName = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerBillingAddress, DateOfRegistration);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CustomerFullNameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerFullName = ""; //this should fail
            CustomerFullName = CustomerFullName.PadRight(51,'a'); //this should fail
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerBillingAddress, DateOfRegistration);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerFullNameExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerFullName = ""; //this should fail
            CustomerFullName = CustomerFullName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerBillingAddress, DateOfRegistration);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //Date of registration validity

        [TestMethod]
        public void DateofRegistrationExtremeMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //Change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateOfRegistration = TestDate.ToString();
            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerBillingAddress, DateOfRegistration);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateofRegistrationMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //Change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateOfRegistration = TestDate.ToString();
            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerBillingAddress, DateOfRegistration);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateofRegistrationMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            
            //convert the date variable to a string variable
            string DateOfRegistration = TestDate.ToString();
            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerBillingAddress, DateOfRegistration);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateofRegistrationMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //Change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateOfRegistration = TestDate.ToString();
            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerBillingAddress, DateOfRegistration);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateofRegistrationExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //Change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateOfRegistration = TestDate.ToString();
            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerBillingAddress, DateOfRegistration);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //invalid data test:
        [TestMethod]
        public void DateOfRegistrationInvalidData()
        {
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the DateOfRegistration to a non date value
            string DateOfRegistration = "This is not a date!";
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerBillingAddress, DateOfRegistration);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
    }
}

