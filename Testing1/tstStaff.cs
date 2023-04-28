using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Testing1
{

  
       
        [TestClass]
    public class tstStaff
    {
        //good test data
        //create some test data to pass to the method
        String fullname = "Nathaniel Hawthorne";
        String role = "Supervisor";
        String employmentdate = DateTime.Now.Date.ToString();
        String salary = "100.00";

        

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
            Staff.EmploymentDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.EmploymentDate, TestData);
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
            Int32 StaffId = 7;
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
            Int32 StaffId = 7;
            //invoke the method
            Found = Staff.Find(StaffId);
            //check the staff id
            if(Staff.StaffId !=7)
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
            Int32 StaffID = 18;
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
            Int32 StaffId = 7;
            //invoke the method
            Found = Staff.Find(StaffId);
            //check the property
            if(Staff.EmploymentDate != Convert.ToDateTime("15/03/23"))
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
            Int32 StaffId = 8;
            //invoke the method
            Found = Staff.Find(StaffId);
            //check the property
            if(Staff.Role != "Developer")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestSalaryFound()
        {
            //create an instance of the class
            clsStaff Staff = new clsStaff();
            //bool variable to store the result of the search
            Boolean Found = false;
            //bool var to record if data is ok (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 StaffId = 17;
            //invoke the method
            Found = Staff.Find(StaffId);
            //check the property
            if (Staff.Salary != 111.99m)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

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
            Int32 StaffId = 7;
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




        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = Staff.Valid(fullname, role, employmentdate, salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }



        [TestMethod]
        public void FullnameMin()
        {

            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String fullname = "a"; //this should trigger an error, if empty
            //invoke the method
            Error = Staff.Valid(fullname, role, employmentdate, salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }




        [TestMethod]
        public void FullnameMinLessOne()
        {

            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String fullname = ""; //this should trigger an error, if empty
            //invoke the method
            Error = Staff.Valid(fullname,  role,  employmentdate, salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }




        [TestMethod]
        public void FullnameMinPlusOne()
        {

            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String fullname = "aa"; //this should be ok
            //invoke the method
            Error = Staff.Valid(fullname, role, employmentdate, salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        public void FullnameMaxLessOne()
        {

            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String fullname = "";
            fullname = fullname.PadRight(39, 'a');//this should be ok
            //invoke the method
            Error = Staff.Valid(fullname, role, employmentdate, salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        public void FullnameMax()
        {

            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String fullname = "";
            fullname = fullname.PadRight(40, 'a');//this should be ok
            //invoke the method
            Error = Staff.Valid(fullname, role, employmentdate, salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        public void FullnameMid()
        {

            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String fullname = "";
            fullname = fullname.PadRight(20, 'a');//this should be ok
            //invoke the method
            Error = Staff.Valid(fullname, role, employmentdate, salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        public void FullnameMaxPlusOne()
        {

            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String fullname = "";
            fullname = fullname.PadRight(41, 'a');//this should fail
            //invoke the method
            Error = Staff.Valid(fullname, role, employmentdate, salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }



        [TestMethod]
        public void FullnameExtremeMax()
        {

            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String fullname = "";
            fullname = fullname.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = Staff.Valid(fullname, role, employmentdate, salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void EmploymentdateExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string employmentdate = TestDate.ToString();
            //invoke the method
            Error=Staff.Valid(fullname, role, employmentdate, salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void EmploymentdateMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string employmentdate = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(fullname, role, employmentdate, salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void EmploymentdateMin()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string employmentdate = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(fullname, role, employmentdate, salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void EmploymentdateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string employmentdate = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(fullname, role, employmentdate, salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //AreNotEqual
        }





        [TestMethod]
        public void EmploymentdateExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string employmentdate = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(fullname, role, employmentdate, salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //AreNotEqual
        }


        [TestMethod]
        public void EmploymentdateInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the employmentdate to a non date value
            string employmentdate = "this is not a date";
            //invoke the method
            Error = Staff.Valid(fullname, role, employmentdate, salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }




        [TestMethod]
        public void RoleMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string role = "";
            //invoke the method
            Error = Staff.Valid(fullname, role, employmentdate, salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");   

        }


        [TestMethod]
        public void RoleMin()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string role = "a";
            //invoke the method
            Error = Staff.Valid(fullname, role, employmentdate, salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");   
        }


        [TestMethod]
        public void RoleMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string role = "aa";
            //invoke the method
            Error = Staff.Valid(fullname, role, employmentdate, salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }





        [TestMethod]
        public void RoleMaxLessOne()
        {

            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String role = "";
            role = role.PadRight(29, 'a');//this should be ok
            //invoke the method
            Error = Staff.Valid(fullname, role, employmentdate, salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        public void RoleMax()
        {

            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String role = "";
            role = role.PadRight(30, 'a');//this should be ok
            //invoke the method
            Error = Staff.Valid(fullname, role, employmentdate, salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        public void RoleMaxPlusOne()
        {

            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String role = "";
            role = role.PadRight(31, 'a');//this should be ok
            //invoke the method
            Error = Staff.Valid(fullname, role, employmentdate, salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void RoleMid()
        {

            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String role = "";
            role = role.PadRight(15, 'a');//this should be ok
            //invoke the method
            Error = Staff.Valid(fullname, role, employmentdate, salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void RoleExtremeMax()
        {

            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String role = "";
            role = role.PadRight(70, 'a');//this should be ok
            //invoke the method
            Error = Staff.Valid(fullname, role, employmentdate, salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }



        [TestMethod]
        public void SalaryExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string salary = "-0.01";
            //invoke the method
            Error = Staff.Valid(fullname, role, employmentdate, salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void SalaryMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string salary = "99.99";
            //invoke the method
            Error = Staff.Valid(fullname, role, employmentdate, salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void SalaryMin()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string salary = "100.00";
            //invoke the method
            Error = Staff.Valid(fullname, role, employmentdate, salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SalaryMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string salary = "100.01";
            //invoke the method
            Error = Staff.Valid(fullname, role, employmentdate, salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SalaryMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string salary = "99999.98";
            //invoke the method
            Error = Staff.Valid(fullname, role, employmentdate, salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SalaryMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string salary = "99999.99";
            //invoke the method
            Error = Staff.Valid(fullname, role, employmentdate, salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SalaryMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string salary = "100001.99";
            //invoke the method
            Error = Staff.Valid(fullname, role, employmentdate, salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void SalaryMid()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string salary = "50000.00";
            //invoke the method
            Error = Staff.Valid(fullname, role, employmentdate, salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SalaryExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string salary = "1000000.00";
            //invoke the method
            Error = Staff.Valid(fullname, role, employmentdate, salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void SalaryInvalid()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string salary = "NotADecimal";
            //invoke the method
            Error = Staff.Valid(fullname, role, employmentdate, salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}
