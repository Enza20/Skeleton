using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplier Supplier = new clsSupplier();
            Assert.IsNotNull(Supplier);
        }


        [TestMethod]
        public void SupplierActivePropertyOK()

        {
            clsSupplier Supplier = new clsSupplier();
            Boolean TestData = true;
            Supplier.SupplierActive = TestData;
            Assert.AreEqual(Supplier.SupplierActive, TestData);
        }


        [TestMethod]
        public void DateOfRegistrationPropertyOK()
        {
            clsSupplier Supplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            Supplier.DateOfRegistration = TestData;            
            Assert.AreEqual(Supplier.DateOfRegistration, TestData);
        }


        [TestMethod]
        public void SupplierIDPropertyOK()
        {
            clsSupplier Supplier = new clsSupplier();
            Int32 TestData = 1;
            Supplier.SupplierID = TestData;
            Assert.AreEqual(Supplier.SupplierID, TestData);
        }


        [TestMethod]
        public void SupplierCompanyNamePropertyOK()
        {
            clsSupplier Supplier = new clsSupplier();
            string TestData = "Goodyear";
            Supplier.SupplierCompanyName = TestData;
            Assert.AreEqual(Supplier.SupplierCompanyName, TestData);
        }


        [TestMethod]
        public void SupplierPhoneNumberPropertyOK()
        {
            clsSupplier Supplier = new clsSupplier();
            string TestData = "07878457785";
            Supplier.SupplierPhoneNumber = TestData;
            Assert.AreEqual(Supplier.SupplierPhoneNumber, TestData);
        }


        [TestMethod]
        public void SupplierVatNumberPropertyOK()
        {
            clsSupplier Supplier = new clsSupplier();
            string TestData = "GB123456789";
            Supplier.SupplierVatNumber = TestData;
            Assert.AreEqual(Supplier.SupplierVatNumber, TestData);
        }


        [TestMethod]
        public void SupplierDeliveryDayPropertyOK()
        {
            clsSupplier Supplier = new clsSupplier();
            string TestData = "Wednesday";
            Supplier.SupplierDeliveryDay = TestData;
            Assert.AreEqual(Supplier.SupplierDeliveryDay, TestData);
        }



    }
}
