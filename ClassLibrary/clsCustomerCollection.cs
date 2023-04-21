using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list 
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
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
        public clsCustomer ThisCustomer { get; set; }
        public  clsCustomerCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count fo records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsCustomer ACustomer = new clsCustomer();
                //read in the fields from the current record
                ACustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                ACustomer.DateOfRegistration  = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfRegistration"]);
                ACustomer.IsAllowed = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsAllowed"]);
                ACustomer.CustomerPhoneNumber= Convert.ToString(DB.DataTable.Rows[Index]["CustomerPhoneNumber"]);
                ACustomer.CustomerBillingAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerBillingAddress"]);
                ACustomer.CustomerFullName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFullName"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point at the next record
                Index++;
            }

       
        //create the items of test data
        clsCustomer TestItem = new clsCustomer();
        //set its properties
            TestItem.CustomerId = 1;
            TestItem.CustomerFullName = "Joe Bloggs";
            TestItem.CustomerPhoneNumber = "01858910635";
            TestItem.CustomerBillingAddress = "13 Chase Road";
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
}

}