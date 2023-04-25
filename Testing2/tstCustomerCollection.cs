using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomerCollection
    {

    /*    [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }
    */
        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerId = 1;
            TestItem.CustomerFullName = "Joe Bloggs";
            TestItem.CustomerPhoneNumber = "01858910635";
            TestItem.CustomerBillingAddress = "13 Chase Road";
            TestItem.DateOfRegistration = DateTime.Now.Date; 
            TestItem.IsAllowed= true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }
       
      /*  [TestMethod]
        public void CountPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Int32 SomeCount = 2;
            AllCustomers.Count = SomeCount;
            Assert.AreEqual(AllCustomers.Count, SomeCount);
        }
      */
        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.CustomerId = 1;
            TestCustomer.CustomerFullName = "Joe Bloggs";
            TestCustomer.CustomerPhoneNumber = "01858910635";
            TestCustomer.CustomerBillingAddress = "13 Chase Road";
            TestCustomer.DateOfRegistration = DateTime.Now.Date;
            TestCustomer.IsAllowed = true;
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //Test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerId = 1;
            TestItem.CustomerFullName = "Joe Bloggs";
            TestItem.CustomerPhoneNumber = "01858910635";
            TestItem.CustomerBillingAddress = "13 Chase Road";
            TestItem.DateOfRegistration = DateTime.Now.Date;
            TestItem.IsAllowed = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }
/*
        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.AreEqual(AllCustomers.Count, 2);
        }
    */
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerId = 7;
            TestItem.CustomerFullName = "Joey Bloggssy";
            TestItem.CustomerPhoneNumber = "078943742";
            TestItem.CustomerBillingAddress = "39 chase road";
            TestItem.DateOfRegistration = DateTime.Now.Date;
            TestItem.IsAllowed = true;
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the PK of the test data
            TestItem.CustomerId = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerFullName = "Joey Bloggs";
            TestItem.CustomerPhoneNumber = "078943742236";
            TestItem.CustomerBillingAddress = "39 chase road";
            TestItem.DateOfRegistration = DateTime.Now.Date;
            TestItem.IsAllowed = true;
            AllCustomers.ThisCustomer = TestItem;
            //set ThisAddress to the test data
            TestItem.CustomerId = PrimaryKey;
            //Modify the test data
            TestItem.CustomerFullName = "Joey BloggsUpdate";
            TestItem.CustomerPhoneNumber = "07543526800";
            TestItem.CustomerBillingAddress = "Another street";
            TestItem.DateOfRegistration = DateTime.Now.Date;
            TestItem.IsAllowed = false;
            //update the record
            AllCustomers.ThisCustomer = TestItem;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerId = 1;
            TestItem.CustomerFullName = "Joey Bloggs";
            TestItem.CustomerPhoneNumber = "078943742236";
            TestItem.CustomerBillingAddress = "39 chase road";
            TestItem.DateOfRegistration = DateTime.Now.Date;
            TestItem.IsAllowed = true;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the PK of the test data
            TestItem.CustomerId = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
           
        }

    }


  
}
