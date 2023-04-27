using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;



namespace Testing1
{
    [TestClass]
   public class tstStaffCollection
    {
        

        [TestMethod]

        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaffs);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Active = true;
            TestItem.StaffId = 1;
            TestItem.FullName = "Sam Smith";
            TestItem.EmploymentDate = DateTime.Now.Date;
            TestItem.Salary = 50.00m;
            TestItem.Role = "Cleaner";

            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaffs.StaffList = TestList;
            //test to see that the 2 values are the same
            Assert.AreEqual(AllStaffs.StaffList, TestList);

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
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object
            TestStaff.Active = true;
            TestStaff.StaffId = 1;
            TestStaff.FullName = "some name";
            TestStaff.EmploymentDate = DateTime.Now.Date;
            TestStaff.Salary = 200.00m;
            TestStaff.Role = "unknown";
            //assign the data to the property
            AllStaffs.ThisStaff = TestStaff;
            //test to see that the 2 values are the same
            Assert.AreEqual(AllStaffs.ThisStaff, TestStaff);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list 
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Active = true;
            TestItem.StaffId = 1;
            TestItem.FullName = "Sam Smith";
            TestItem.EmploymentDate = DateTime.Now.Date;
            TestItem.Salary = 50.00m;
            TestItem.Role = "Supervisor";
            //add the item to the test list
            TestList.Add(TestItem);
            //asign the data to the property
            AllStaffs.StaffList = TestList;
            //test to see that the 2 values are the same
            Assert.AreEqual(AllStaffs.Count, TestList.Count);

        }


     /*   [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //test to see that the values are the same
            Assert.AreEqual(AllStaffs.Count, 2);
        }    */


        



        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.StaffId = 1;
            TestItem.FullName = "Chico Pufu";
            TestItem.EmploymentDate = DateTime.Now.Date;
            TestItem.Salary = 50.00m;
            TestItem.Role = "Supervisor";
            //set ThisAddress to the test data
            AllStaffs.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaffs.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //find the record
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.FullName = "Chico Pufu";
            TestItem.EmploymentDate = DateTime.Now.Date;
            TestItem.Salary = 100.00m;
            TestItem.Role = "Supervisor";
            //set ThisStaff to the test data
            AllStaffs.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaffs.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //TestItem.StaffId = AllStaffs.ThisStaff.StaffId;
            System.Threading.Thread.Sleep(100);

            //modify the test data
            TestItem.Active = false;
            TestItem.FullName = "Marius Pufu";
            TestItem.EmploymentDate = DateTime.Now.Date;
            TestItem.Salary = 200.00m;
            TestItem.Role = "Manager";
            //set the record based on the new test data
            AllStaffs.ThisStaff = TestItem;

            
            //update the record
            AllStaffs.Update();
            //find the record
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //test to see ThisStaff matches the test data
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);

        }

       

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.StaffId = 1;
            TestItem.FullName = "Chico Pufu";
            TestItem.EmploymentDate = DateTime.Now.Date;
            TestItem.Salary = 50.00m;
            TestItem.Role = "Supervisor";
            //set ThisAddress to the test data
            AllStaffs.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaffs.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //find the record
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaffs.Delete();
            Boolean Found = AllStaffs.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByFullNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create an instance if the filtered data
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //appply a blank string (should return all records)
            FilteredStaffs.ReportByFullName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.Count, FilteredStaffs.Count);
        }



        [TestMethod]
        public void ReportByFullNameNoneFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //apply a name that does not exist
            FilteredStaffs.ReportByFullName("xxx xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStaffs.Count);
        }

        [TestMethod]
        public void ReportByFullNameTestDataFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a full name that does not exist
            FilteredStaffs.ReportByFullName("John Wick");
            //check that the correct number of records are found
            if (FilteredStaffs.Count == 2)
            {
                //check that the first record is ID 1
                if(FilteredStaffs.StaffList[0].StaffId != 1)
                {
                    OK = false;
                }
                //check that record is ID 2
                if(FilteredStaffs.StaffList[1].StaffId != 2)
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