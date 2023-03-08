using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Testing1
{


    [TestClass]
    public class tstStaff
    {
        private int mStaffId;

        [TestMethod]
        public void InstanceOK()
        { 
            //create an instance of the class we want to create

            clsStaff Staff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(Staff);
        }


        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data
            Boolean TestData = true;
            //assign the data to the propery
            Staff.Active = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(Staff.Active, TestData);

        }



        [TestMethod]
        public void EmploymentDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            Staff.Date = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.Date, TestData);
        }

        [TestMethod]
        public void StaffIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            Staff.StaffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.StaffId, TestData);
        }


        [TestMethod]
        public void FullNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data to assign the property
            string TestData = "Joe Bloggs";
            //assign the data to the property
            Staff.FullName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.FullName, TestData);
        }


        [TestMethod]
        public void SalaryPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data to assign the property
            decimal TestData = 500; //check this
            //assign the test data to the property 
            Staff.Salary = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.Salary, TestData);
        }


        [TestMethod]
        public void RolePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Manager";
            //assign the data to the property
            Staff.Role = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.Role, TestData);
        }


        [TestMethod]
        public void FindMethodOK()
        {

            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = Staff.Find(StaffId);
            //test to see if the result is true
            Assert.IsTrue(Found);

        }



        [TestMethod]
        public void TestStaffIdFound()
        {

            //create an instance of the class
            clsStaff Staff = new clsStaff();
            //bool var to store the result of the search
            Boolean Found = false;
            //bool var to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = Staff.Find(StaffId);
            //check the staff id
            if(Staff.StaffId !=1)
            {
                OK = false;

            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


       

        [TestMethod]
        public void TestFullNameFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to store the result of teh search
            Boolean Found = false;
            //boolean variable to record if data is OK (Assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = Staff.Find(StaffID);

            //check the property
            if (Staff.FullName != "Trevor Potts")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void TestEmploymentDateFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //bool variable to store the result of the search
            Boolean Found = false;
            //bool var to record if data is ok (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = Staff.Find(StaffId);
            //check the property
            if(Staff.Date != Convert.ToDateTime("17/01/2017"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]

        public void TestRoleFound()
        {
            //create an instance of the class
            clsStaff Staff = new clsStaff();
            //bool variable to store the result of the search
            Boolean Found = false;
            //bool var to record if data is ok (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = Staff.Find(StaffId);
            //check the property
            if(Staff.Role != "Manager")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestSalaryFound()
        {


        }





        [TestMethod]
        public void TestActiveFound()
        {

            //create an instance of the class
            clsStaff Staff = new clsStaff();
            //bool variable to store the result of the search
            Boolean Found = false;
            //bool var to record if data is ok (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = Staff.Find(StaffId);
            //check the property
            if(Staff.Active != true)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);


        }
    }
}
