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

        public void FindMethodOK()
        {
            clsStock Stock = new clsStock();
            Boolean Found = false;
            Int32 ProductID = 1;
            Found = Stock.Find(ProductID);
            Assert.IsTrue(Found);
        }

        public void TestProductIDFound()
        {
            clsStock Stock = new clsStock();
            Boolean Found = false;
            Boolean ok = true;
            Int32 ProductID = 1;
            Found = Stock.Find(ProductID);
            if(Stock.ProductID != 1)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        public void TestDescriptionFound()
        {
            clsStock Stock = new clsStock();
            Boolean Found = false;
            Boolean ok = true;
            Int32 ProductID = 1;
            Found = Stock.Find(ProductID);
            if(Stock.Description != "Test Description")
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        public void TestQuantityFound()
        {
            clsStock Stock = new clsStock();
            Boolean Found = false;
            Boolean ok = true;
            Int32 ProductID = 1;
            Found = Stock.Find(ProductID);
            if (Stock.Quantity != 1)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        public void TestSupplierIDFound()
        {
            clsStock Stock = new clsStock();
            Boolean Found = false;
            Boolean ok = true;
            Int32 ProductID = 1;
            Found = Stock.Find(ProductID);
            if (Stock.SupplierID != 1)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        public void TestExpiryDateFound()
        {
            clsStock Stock = new clsStock();
            Boolean Found = false;
            Boolean ok = true;
            Int32 ProductID = 1;
            Found = Stock.Find(ProductID);
            if (Stock.ExpiryDate != Convert.ToDateTime("16/09/2025"))
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        public void TestProductPriceFound()
        {
            clsStock Stock = new clsStock();
            Boolean Found = false;
            Boolean ok = true;
            Int32 ProductID = 1;
            Found = Stock.Find(ProductID);
            if (Stock.ProductPrice != 5.0)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        public void TestCanPurchaseFound()
        {
            clsStock Stock = new clsStock();
            Boolean Found = false;
            Boolean ok = true;
            Int32 ProductID = 1;
            Found = Stock.Find(ProductID);
            if (Stock.CanPurchase != true)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
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
