using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member thisStaff
        clsStaff mThisStaff = new clsStaff();

        //constructor for the class
        public clsStaffCollection()
        {
           
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }



        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff
                clsStaff Staff = new clsStaff();
                //read in the fields from the current record
                Staff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                Staff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                Staff.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                Staff.EmploymentDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["EmploymentDate"]);
                Staff.Salary = Convert.ToDecimal(DB.DataTable.Rows[Index]["Salary"]);
                Staff.Role = Convert.ToString(DB.DataTable.Rows[Index]["Role"]);

                //add the record to the private data member
                mStaffList.Add(Staff);
                //point at the next record
                Index++;

            }
        }

        //public property for the staff list
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }
        
        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;

            }
            set
            {
                //later
            }
        }

        //public property for ThisStaff
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }


        public int Add()
        {
            //adds a new record to the database based on the values of thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FullName", mThisStaff.FullName);
            DB.AddParameter("@Role", mThisStaff.Role);
            DB.AddParameter("@Active", mThisStaff.Active);
            DB.AddParameter("@EmploymentDate", mThisStaff.EmploymentDate);
            DB.AddParameter("@Salary", mThisStaff.Salary);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }


        public void Update()
        {
            //update an existing record based on the values of thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedures
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.AddParameter("@FullName", mThisStaff.FullName);
            DB.AddParameter("@Role", mThisStaff.Role);
            DB.AddParameter("@Active", mThisStaff.Active);
            DB.AddParameter("@EmploymentDate", mThisStaff.EmploymentDate);
            DB.AddParameter("@Salary", mThisStaff.Salary);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");

        }


        public void Delete()
        {
            //deletes the record pointed to by thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        //constructor for the class
        /* public clsStaffCollection()
         {
             //create the items of test data
             clsStaff TestItem = new clsStaff();
             //set its properties
             TestItem.Active = true;
             TestItem.StaffId = 1;
             TestItem.FullName = "Sam Smith";
             TestItem.EmploymentDate = DateTime.Now.Date;
             TestItem.Salary = 50.00m;
             TestItem.Role = "Supervisor";
             //add the item to the list
             mStaffList.Add(TestItem);
             //re initialise the object for some new data
             TestItem = new clsStaff();
             //set its properties
             //set the properties of the test object
             TestItem.Active = true;
             TestItem.StaffId = 1;
             TestItem.FullName = "some name";
             TestItem.EmploymentDate = DateTime.Now.Date;
             TestItem.Salary = 200.00m;
             TestItem.Role = "unknown";
             //add it to the test list
             mStaffList.Add(TestItem);

         }     */




       
       

        public void ReportByFullName(string FullName)
        {
            //filters the records based on a full or partial name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the FullName parameter to the database
            DB.AddParameter("@FullName", FullName);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByFullName");
            //populate the array list with the data table
            PopulateArray(DB);
            
               
        }


    }


}