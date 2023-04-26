using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list 
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }
        //public poroperty for count
        public int Count
        {
            get
            {
                //return the private data
                return mCustomerList.Count;
            }
            set
            {
               
            }
        }
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }
        public  clsCustomerCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
            }

    

 /*       //create the items of test data
        clsCustomer TestItem = new clsCustomer();
        //set its properties
            TestItem.CustomerId = 10;
            TestItem.CustomerFullName = "Joey Person";
            TestItem.CustomerPhoneNumber = "0347382643";
            TestItem.CustomerBillingAddress = "39 road";
            TestItem.DateOfRegistration = DateTime.Now.Date;
            TestItem.IsAllowed = true;

            //Add the item to the test list
            mCustomerList.Add(TestItem);

            //set its properties
            TestItem.CustomerId = 2;
            TestItem.CustomerFullName = "Some One";
            TestItem.CustomerPhoneNumber = "071826327827";
            TestItem.CustomerBillingAddress = "1 DMU Close";
            TestItem.DateOfRegistration = DateTime.Now.Date;
            TestItem.IsAllowed = true;

            //Add the item to the test list
            mCustomerList.Add(TestItem);
            }
 */
        public int Add()
        {
            //adds a new record to the database on the values of mthiscustomer
            clsDataConnection DB = new clsDataConnection();
            //set the parms for the SP
            DB.AddParameter("@CustomerFullName", mThisCustomer.CustomerFullName);
            DB.AddParameter("@CustomerPhoneNumber", mThisCustomer.CustomerPhoneNumber);
            DB.AddParameter("@CustomerBillingAddress", mThisCustomer.CustomerBillingAddress);
            DB.AddParameter("@DateOfRegistration", mThisCustomer.DateOfRegistration);
            DB.AddParameter("@IsAllowed", mThisCustomer.IsAllowed);
            //execute the query returning the PK value
            return DB.Execute("sproc_tblCustomer_Insert");

          /*  //set the PK value of the new record
            mThisCustomer.CustomerId = 7;
            //return the PK of the new record
            return mThisCustomer.CustomerId;
          */
        }


        public void Update()
        {
            //update an existing record based on the values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@CustomerFullName", mThisCustomer.CustomerFullName);
            DB.AddParameter("@CustomerPhoneNumber", mThisCustomer.CustomerPhoneNumber);
            DB.AddParameter("@CustomerBillingAddress", mThisCustomer.CustomerBillingAddress);
            DB.AddParameter("@DateOfRegistration", mThisCustomer.DateOfRegistration);
            DB.AddParameter("@IsAllowed", mThisCustomer.IsAllowed);
            //execute the stored [rpcedure
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByBillingAddress(string CustomerBillingAddress)
        {
            //filters the records based on a full or partial post code
            //connect to the DB
            clsDataConnection DB = new clsDataConnection();
            //send the aaddress param to the database
            DB.AddParameter("@CustomerBillingAddress", CustomerBillingAddress);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerBillingAddress");
        //populate the arry list with the data table
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
            mCustomerList = new List<clsCustomer>();
            //while ther are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsCustomer ACustomer = new clsCustomer();
                //read in the fields from the current record
                ACustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                ACustomer.DateOfRegistration = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfRegistration"]);
                ACustomer.IsAllowed = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsAllowed"]);
                ACustomer.CustomerPhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPhoneNumber"]);
                ACustomer.CustomerBillingAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerBillingAddress"]);
                ACustomer.CustomerFullName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFullName"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point at the next record
                Index++;

            }
        
        
        }
    }

}