using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
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
    }
}
