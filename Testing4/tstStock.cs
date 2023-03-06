using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstStock

    {

        int id = 1;
        string description = "Random description";
        int quantity = 1;
        int supplierid = 1;
        string expirydate = DateTime.Now.Date.ToString();
        double price = 2.1;


        [TestMethod]
        public void InstanceOK()
        {
            clsStock Stock = new clsStock();
            Assert.IsNotNull(Stock);
        }

        [TestMethod]

        public void ActivePropertyOK()
        {
            clsStock Stock = new clsStock();

            Boolean TestData = true;

            Stock.Active = TestData;

            Assert.AreEqual(Stock.Active, TestData);
        }

        public void ProductIDOK()
        {
            clsStock Stock = new clsStock();

            Int32 TestData = 1;

            Stock.ProductID = TestData;

            Assert.AreEqual(Stock.ProductID, TestData);
        }

        public void DescriptionOK()
        {
            clsStock Stock = new clsStock();

            string TestData = "ok";

            Stock.Description = TestData;

            Assert.AreEqual(Stock.Description, TestData);
        }

        public void QuantityOK()
        {
            clsStock Stock = new clsStock();

            Int32 TestData = 1;

            Stock.Quantity = TestData;

            Assert.AreEqual(Stock.Quantity, TestData);
        }

        public void SupplierIDOK()
        {
            clsStock Stock = new clsStock();

            Int32 TestData = 1;

            Stock.SupplierID = TestData;

            Assert.AreEqual(Stock.SupplierID, TestData);
        }

        public void ExpiryDateOK()
        {
            clsStock Stock = new clsStock();

            DateTime TestData = DateTime.Now.Date;

            Stock.ExpiryDate = TestData;

            Assert.AreEqual(Stock.ExpiryDate, TestData);
        }

        public void ProductPriceOK()
        {
            clsStock Stock = new clsStock();

            double TestData = 1;

            Stock.ProductPrice = TestData;

            Assert.AreEqual(Stock.ProductPrice, TestData);
        }

        public void CanPurchaseOK()
        {
            clsStock Stock = new clsStock();

            Boolean TestData = true;

            Stock.CanPurchase = TestData;

            Assert.AreEqual(Stock.CanPurchase, TestData);
        }

        public void ValidMethodOK()
        {
            clsStock Stock = new clsStock();

            String Error = "";

            Error = Stock.Valid(id, description, quantity, supplierid, expirydate, price);

            Assert.AreEqual(Error, "");
        }
    }
}
