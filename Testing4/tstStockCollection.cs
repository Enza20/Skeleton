using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{

    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllAddresses = new clsStockCollection();
            Assert.IsNotNull(AllAddresses);
        }

        [TestMethod]
        public void StockListOK()
        {
            //create an instance of class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            //in this case data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.CanPurchase = true;
            TestItem.ProductID = 1;
            TestItem.Description = "random";
            TestItem.ExpiryDate = DateTime.Now.Date;
            TestItem.ProductPrice = 50.00m;
            TestItem.Quantity = 1;
            TestItem.SupplierID = 10;

            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the 2 values are the same
            Assert.AreEqual(AllStock.StockList, TestList);

        }



        /* [TestMethod]
         public void CountPropertyOK()
         {
             //create an instance of the class we want to create
             clsStaffCollection AllStaffs = new clsStaffCollection();
             //create some test data to assign to the property
             Int32 SomeCount = 2;
             //assign the data to the property
             Assert.AreEqual(AllStaffs.Count, SomeCount);
         }  */


        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //set the properties of the test object
            TestStock.CanPurchase = true;
            TestStock.ProductID = 1;
            TestStock.Description = "some name";
            TestStock.ExpiryDate = DateTime.Now.Date;
            TestStock.ProductPrice = 200.00m;
            TestStock.Quantity = 1;
            TestStock.SupplierID = 2;
            //assign the data to the property
            AllStock.ThisStock = TestStock;
            //test to see that the 2 values are the same
            Assert.AreEqual(AllStock.ThisStock, TestStock);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list 
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.CanPurchase = true;
            TestItem.ProductID = 2;
            TestItem.Description = "Random";
            TestItem.ExpiryDate = DateTime.Parse("31/07/2023 00:00:00");
            TestItem.ProductPrice = 2.60m;
            TestItem.Quantity = 49;
            TestItem.SupplierID = 2;
            //add the item to the test list
            TestList.Add(TestItem);
            //asign the data to the property
            AllStock.StockList = TestList;
            //test to see that the 2 values are the same
            Assert.AreEqual(AllStock.Count, TestList.Count);

        }








        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CanPurchase = true;
            TestItem.ProductID = 2;
            TestItem.Description = "Random";
            TestItem.ExpiryDate = DateTime.Parse("31/07/2023 00:00:00");
            TestItem.ProductPrice = 2.60m;
            TestItem.Quantity = 49;
            TestItem.SupplierID = 2;
            //set ThisAddress to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.ProductID = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestItem);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CanPurchase = true;
            TestItem.Description = "Random";
            TestItem.ExpiryDate = DateTime.Now.Date;
            TestItem.ProductPrice = 2.60m;
            TestItem.Quantity = 44;
            TestItem.SupplierID = 2;
           
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.ProductID = PrimaryKey;
           
            System.Threading.Thread.Sleep(100);

            //modify the test data
            TestItem.CanPurchase = false;
            TestItem.Description = "Bad product";
            TestItem.ExpiryDate = DateTime.Now.Date;
            TestItem.ProductPrice = 52.00m;
            TestItem.Quantity = 11;
            TestItem.SupplierID = 28;
            //set the record based on the new test data
            AllStock.ThisStock = TestItem;


            //update the record
            AllStock.Update();
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see ThisStaff matches the test data
            Assert.AreEqual(AllStock.ThisStock, TestItem);

        }



        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CanPurchase = true;
            TestItem.ProductID = 2;
            TestItem.Description = "Random";
            TestItem.ExpiryDate = DateTime.Parse("31/07/2023 00:00:00");
            TestItem.ProductPrice = 2.60m;
            TestItem.Quantity = 49;
            //set ThisAddress to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.ProductID = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //delete the record
            AllStock.Delete();
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByDescriptionMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStockCollection AllStock = new clsStockCollection();
            //create an instance if the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //appply a blank string (should return all records)
            FilteredStock.ReportByDescription("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, FilteredStock.Count);
        }



        [TestMethod]
        public void ReportByDescriptionNoneFound()
        {
            //create an instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a name that does not exist
            FilteredStock.ReportByDescription("xxx xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportByDescriptionTestDataFound()
        {
            //create an instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a full name that does not exist
            FilteredStock.ReportByDescription("Last one");
            //check that the correct number of records are found
            if (FilteredStock.Count == 2)
            {
                //check that the first record is ID 1
                if (FilteredStock.StockList[0].ProductID != 1)
                {
                    OK = false;
                }
                //check that record is ID 2
                if (FilteredStock.StockList[1].ProductID != 2)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
