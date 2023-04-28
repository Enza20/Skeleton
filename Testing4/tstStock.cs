using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstStock

    {

        string description = "Random description";
        int quantity = 1;
        int supplierid = 1;
        string expirydate = DateTime.Now.Date.ToString();
        decimal price = 2.1m;


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

        [TestMethod]
        public void ProductIDOK()
        {
            clsStock Stock = new clsStock();

            Int32 TestData = 1;

            Stock.ProductID = TestData;

            Assert.AreEqual(Stock.ProductID, TestData);
        }
        [TestMethod]
        public void DescriptionOK()
        {
            clsStock Stock = new clsStock();

            string TestData = "ok";

            Stock.Description = TestData;

            Assert.AreEqual(Stock.Description, TestData);
        }
        [TestMethod]
        public void QuantityOK()
        {
            clsStock Stock = new clsStock();

            Int32 TestData = 1;

            Stock.Quantity = TestData;

            Assert.AreEqual(Stock.Quantity, TestData);
        }
        [TestMethod]
        public void SupplierIDOK()
        {
            clsStock Stock = new clsStock();

            Int32 TestData = 1;

            Stock.SupplierID = TestData;

            Assert.AreEqual(Stock.SupplierID, TestData);
        }
        [TestMethod]
        public void ExpiryDateOK()
        {
            clsStock Stock = new clsStock();

            DateTime TestData = DateTime.Now.Date;

            Stock.ExpiryDate = TestData;

            Assert.AreEqual(Stock.ExpiryDate, TestData);
        }
        [TestMethod]
        public void ProductPriceOK()
        {
            clsStock Stock = new clsStock();

            decimal TestData = 1;

            Stock.ProductPrice = TestData;

            Assert.AreEqual(Stock.ProductPrice, TestData);
        }
        [TestMethod]
        public void CanPurchaseOK()
        {
            clsStock Stock = new clsStock();

            Boolean TestData = true;

            Stock.CanPurchase = TestData;

            Assert.AreEqual(Stock.CanPurchase, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsStock Stock = new clsStock();
            Boolean Found = false;
            Int32 ProductID = 1;
            Found = Stock.Find(ProductID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
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
        [TestMethod]
        public void TestDescriptionFound()
        {
            clsStock Stock = new clsStock();
            Boolean Found = false;
            Boolean ok = true;
            Int32 ProductID = 1;
            Found = Stock.Find(ProductID);
            if(Stock.Description != "Test")
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }
        [TestMethod]
        public void TestQuantityFound()
        {
            clsStock Stock = new clsStock();
            Boolean Found = false;
            Boolean ok = true;
            Int32 ProductID = 1;
            Found = Stock.Find(ProductID);
            if (Stock.Quantity != 5)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }
        [TestMethod]
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
        [TestMethod]
        public void TestExpiryDateFound()
        {
            clsStock Stock = new clsStock();
            Boolean Found = false;
            Boolean ok = true;
            Int32 ProductID = 1;
            Found = Stock.Find(ProductID);
            if (Stock.ExpiryDate != Convert.ToDateTime("21/05/2028"))
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }
        [TestMethod]
        public void TestProductPriceFound()
        {
            clsStock Stock = new clsStock();
            Boolean Found = false;
            Boolean ok = true;
            Int32 ProductID = 1;
            Found = Stock.Find(ProductID);
            if (Stock.ProductPrice != 3.0m)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }
        [TestMethod]
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
        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock Stock = new clsStock();

            String Error = "";

            Error = Stock.Valid(description, quantity, supplierid, expirydate, price);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMid()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            string Description = "";
            Description = Description.PadRight(250, 'a');
            Error = Stock.Valid(Description, quantity, supplierid, expirydate, price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
       public void DescriptionMaxLessOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            string Description = "";
            Description = Description.PadRight(499, 'a');
            Error = Stock.Valid(Description, quantity, supplierid, expirydate, price);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DescriptionMax()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            string Description = "";
            Description = Description.PadRight(500, 'a');
            Error = Stock.Valid(Description, quantity, supplierid, expirydate, price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxPlusOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            string Description = "";
            Description = Description.PadRight(501, 'a');
            Error = Stock.Valid(Description, quantity, supplierid, expirydate, price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionExtremeMax()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            string Description = "";
            Description = Description.PadRight(1000, 'a');
            Error = Stock.Valid(Description, quantity, supplierid, expirydate, price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinLessOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            Int32 Quantity = -1;
            Error = Stock.Valid(description, Quantity, supplierid, expirydate, price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMin()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            Int32 Quantity = 0;
            Error = Stock.Valid(description, Quantity, supplierid, expirydate, price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            Int32 Quantity = 1;
            Error = Stock.Valid(description, Quantity, supplierid, expirydate, price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMid()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            Int32 Quantity = 5000;
            Error = Stock.Valid(description, Quantity, supplierid, expirydate, price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxLessOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            Int32 Quantity = 9999;
            Error = Stock.Valid(description, Quantity, supplierid, expirydate, price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMax()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            Int32 Quantity = 10000;
            Error = Stock.Valid(description, Quantity, supplierid, expirydate, price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            Int32 Quantity = 10001;
            Error = Stock.Valid(description, Quantity, supplierid, expirydate, price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityExtremeMax()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            Int32 Quantity = 999999;
            Error = Stock.Valid(description, Quantity, supplierid, expirydate, price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIDMinLessOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            Int32 SupplierID = 0;
            Error = Stock.Valid(description, quantity, SupplierID, expirydate, price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIDMin()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            Int32 SupplierID = 1;
            Error = Stock.Valid(description, quantity, SupplierID, expirydate, price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIDMinPlusOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            Int32 SupplierID = 2;
            Error = Stock.Valid(description, quantity, SupplierID, expirydate, price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIDMid()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            Int32 SupplierID = 500;
            Error = Stock.Valid(description, quantity, SupplierID, expirydate, price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIDMaxLessOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            Int32 SupplierID = 999;
            Error = Stock.Valid(description, quantity, SupplierID, expirydate, price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIDMax()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            Int32 SupplierID = 1000;
            Error = Stock.Valid(description, quantity, SupplierID, expirydate, price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIDMaxPlusOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            Int32 SupplierID = 1001;
            Error = Stock.Valid(description, quantity, SupplierID, expirydate, price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIDExtremeMax()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            Int32 SupplierID = 100000;
            Error = Stock.Valid(description, quantity, SupplierID, expirydate, price);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void ExpiryDateExtremeMin()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string ExpiryDate = TestDate.ToString();
            Error = Stock.Valid(description, quantity, supplierid, ExpiryDate, price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ExpiryDateMinLessOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string ExpiryDate = TestDate.ToString();
            Error = Stock.Valid(description, quantity, supplierid, ExpiryDate, price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ExpiryDateMin()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string ExpiryDate = TestDate.ToString();
            Error = Stock.Valid(description, quantity, supplierid, ExpiryDate, price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ExpiryDateMinPlusOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string ExpiryDate = TestDate.ToString();
            Error = Stock.Valid(description, quantity, supplierid, ExpiryDate, price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ExpiryDateMid()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(10);
            string ExpiryDate = TestDate.ToString();
            Error = Stock.Valid(description, quantity, supplierid, ExpiryDate, price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ExpiryDateMaxLessOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(20);
            TestDate = TestDate.AddDays(-1);
            string ExpiryDate = TestDate.ToString();
            Error = Stock.Valid(description, quantity, supplierid, ExpiryDate, price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ExpiryDateMax()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(20);
            string ExpiryDate = TestDate.ToString();
            Error = Stock.Valid(description, quantity, supplierid, ExpiryDate, price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ExpiryDateMaxPlusOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(20);
            TestDate = TestDate.AddDays(1);
            string ExpiryDate = TestDate.ToString();
            Error = Stock.Valid(description, quantity, supplierid, ExpiryDate, price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ExpiryDateExtremeMax()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(200);
            string ExpiryDate = TestDate.ToString();
            Error = Stock.Valid(description, quantity, supplierid, ExpiryDate, price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ExpiryDateInvalidData()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            string ExpiryDate = "Not a date";
            Error = Stock.Valid(description, quantity, supplierid, ExpiryDate, price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductPriceExtremeMin()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            decimal ProductPrice = -10.0m;
            Error = Stock.Valid(description, quantity, supplierid, expirydate, ProductPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductPriceMinLessOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            decimal ProductPrice = 0.00m;
            Error = Stock.Valid(description, quantity, supplierid, expirydate, ProductPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductPriceMin()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            decimal ProductPrice = 0.01m;
            Error = Stock.Valid(description, quantity, supplierid, expirydate, ProductPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductPriceMinPlusOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            decimal ProductPrice = 0.02m;
            Error = Stock.Valid(description, quantity, supplierid, expirydate, ProductPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductPriceMid()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            decimal ProductPrice = 5000.00m;
            Error = Stock.Valid(description, quantity, supplierid, expirydate, ProductPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductPriceMaxLessOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            decimal ProductPrice = 9999.98m;
            Error = Stock.Valid(description, quantity, supplierid, expirydate, ProductPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductPriceMax()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            decimal ProductPrice = 9999.99m;
            Error = Stock.Valid(description, quantity, supplierid, expirydate, ProductPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductPriceMaxPlusOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            decimal ProductPrice = 10000.00m;
            Error = Stock.Valid(description, quantity, supplierid, expirydate, ProductPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductPriceExtremeMax()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            decimal ProductPrice = 1000000.00m;
            Error = Stock.Valid(description, quantity, supplierid, expirydate, ProductPrice);
            Assert.AreNotEqual(Error, "");
        }
    }
}
