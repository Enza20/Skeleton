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

        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //create some test data
            Boolean TestData = true;
            //assign the data to the propery
            Customer.Active = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(Customer.Active, TestData);

        }
    }
}

