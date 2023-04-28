using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstSupplier
    {
        //good test data
        string SupplierCompanyName = "Boden";
        string SupplierPhoneNumber = "07848755874";
        string SupplierVatNumber = "GB547845217";
        string DateOfRegistration = DateTime.Now.Date.ToString();
        string SupplierDeliveryDay = "1 dmu close";

        

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
            Int32 TestData = 4;
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


        [TestMethod]
        public void FindMethodOK()
        {
            clsSupplier Supplier = new clsSupplier();
            Boolean Found = false;
            Int32 SupplierID = 1;
            Found = Supplier.Find(SupplierID);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestSupplierIDFound()
        {
            clsSupplier Supplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 1;
            Found = Supplier.Find(SupplierID);
            
            if (Supplier.SupplierID != 1)
            {
                OK = false;
            }
            
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestSupplierCompanyNameFound()
        {
            clsSupplier Supplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 1;
            Found = Supplier.Find(SupplierID);

            if (Supplier.SupplierCompanyName != "Asda                                              ")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierPhoneNumberFound()
        {
            clsSupplier Supplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 1;
            Found = Supplier.Find(SupplierID);

            if (Supplier.SupplierPhoneNumber != "07415478547     ")
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestSupplierVatNumberFound()
        {
            clsSupplier Supplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 1;
            Found = Supplier.Find(SupplierID);

            if (Supplier.SupplierVatNumber != "GB547845217      ")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void TestDateOfRegistrationFound()
        {
            clsSupplier Supplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 1;
            Found = Supplier.Find(SupplierID);
            if (Supplier.DateOfRegistration !=Convert.ToDateTime("07/05/2012"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestSupplierDeliveryDayFound()
        {
            clsSupplier Supplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 1;
            Found = Supplier.Find(SupplierID);

            if (Supplier.SupplierDeliveryDay != "Monday              ")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestSupplierActiveFound()
        {
            clsSupplier Supplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 1;
            Found = Supplier.Find(SupplierID);
            if (Supplier.SupplierActive != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        public void ValidMethodOK()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreEqual(Error, "");
        }

        //company name


        [TestMethod]
        public void SupplierCompanyNameMinLessOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierCompanyName = "";
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void SupplierCompanyNameMin()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierCompanyName = "d"; 
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void SupplierCompanyNameMinPlusOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierCompanyName = "dd"; 
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void SupplierCompanyNameMaxLessOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierCompanyName = "ddddddddddddddddddddddddddddddddddddddddddddddddd"; 
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void SupplierCompanyNameMax()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierCompanyName = "dddddddddddddddddddddddddddddddddddddddddddddddddd"; 
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void SupplierCompanyNameMid()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierCompanyName = "ddddddddddddddddddddddddd"; 
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void SupplierCompanyNameMaxPlusOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierCompanyName = ""; 
            SupplierCompanyName = SupplierCompanyName.PadRight(51, 'd');
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void SupplierCompanyNameExtremeMax()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierCompanyName = ""; 
            SupplierCompanyName = SupplierCompanyName.PadRight(500, 'd'); 
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreNotEqual(Error, "");
        }


        //Phone number


        [TestMethod]
        public void SupplierPhoneNumberMinLessOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierPhoneNumber = "";
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void SupplierPhoneNumberNameMin()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierPhoneNumber = "1";
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void SupplierPhoneNumberMinPlusOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierPhoneNumber = "11";
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void SupplierPhoneNumberMaxLessOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierPhoneNumber = "111111111111111";
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void SupplierPhoneNumberNameMax()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierPhoneNumber = "1111111111111111";
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void SupplierPhoneNumberNameMid()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierPhoneNumber = "11111111";
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void SupplierPhoneNumberMaxPlusOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierPhoneNumber = "";
            SupplierPhoneNumber = SupplierPhoneNumber.PadRight(17, '1');
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void SupplierPhoneNumberExtremeMax()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierPhoneNumber = "";
            SupplierPhoneNumber = SupplierPhoneNumber.PadRight(500, '1');
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreNotEqual(Error, "");
        }


        //VAT Number


        [TestMethod]
        public void SupplierVatNumberMinLessOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierVatNumber = "";
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void SupplierVatNumberMin()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierVatNumber = "1";
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void SupplierVatNumberMinPlusOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierVatNumber = "12";
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void SupplierVatNumberMaxLessOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierVatNumber = "1111111111111111";
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void SupplierVatNumberNameMax()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierVatNumber = "11111111111111111";
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void SupplierVatNumberNameMid()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierVatNumber = "123456789";
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void SupplierVatNumberMaxPlusOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierVatNumber = "";
            SupplierVatNumber = SupplierVatNumber.PadRight(18, '1');
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void SupplierVatNumberExtremeMax()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierVatNumber = "";
            SupplierVatNumber = SupplierVatNumber.PadRight(500, '1');
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreNotEqual(Error, "");
        }


        //Delivery day


        [TestMethod]
        public void SupplierDeliveryDayMinLessOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierDeliveryDay = "";
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void SupplierDeliveryDayMin()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierDeliveryDay = "d";
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void SupplierDeliveryDayMinPlusOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierDeliveryDay = "dd";
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void SupplierDeliveryDayMaxLessOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierDeliveryDay = "ddddddddddddddddddd";
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void SupplierDeliveryDayMax()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierDeliveryDay = "dddddddddddddddddddd";
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void SupplierDeliveryDayMid()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierDeliveryDay = "dddddddddd";
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void SupplierDeliveryDayMaxPlusOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierDeliveryDay = "";
            SupplierDeliveryDay = SupplierDeliveryDay.PadRight(21, 'd');
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void SupplierDeliveryDayExtremeMax()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierDeliveryDay = "";
            SupplierDeliveryDay = SupplierDeliveryDay.PadRight(500, 'd');
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreNotEqual(Error, "");
        }

        //Date
        [TestMethod]
        public void DateofRegistrationExtremeMin()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateOfRegistration = TestDate.ToString();
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateofRegistrationMinLessOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateOfRegistration = TestDate.ToString();
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateofRegistrationMin()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateOfRegistration = TestDate.ToString();
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateofRegistrationMinPlusOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateOfRegistration = TestDate.ToString();
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateofRegistrationExtremeMax()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateOfRegistration = TestDate.ToString();
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreNotEqual(Error, "");
        }

        //invalid data test:
        [TestMethod]
        public void DateOfRegistrationInvalidData()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string DateOfRegistration = "This is not a date!";
            Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
            Assert.AreNotEqual(Error, "");

        }




    }
}
