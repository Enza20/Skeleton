using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClassLibrary
{
    public class clsCustomer
    {
       //CustomerNo private member variable
        private Int32 mCustomerId;
      
        //public property for the customer number
        public int CustomerId
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerId;

            }
            set
            {
                //this line of code allows data into the property
                mCustomerId = value;
            }
        
        }     
        
        //CustomerFullName private member variable
        private string mCustomerFullName;
        public string CustomerFullName
        {
            get
            {
                //return the private data
                return mCustomerFullName;
            }
            set
            {
                //set the private data
                mCustomerFullName = value;
            }
        }

        //CustomerNo private member variable
        private string mCustomerPhoneNumber;
        public string CustomerPhoneNumber
        {
            get
            {
                //return the private data
                return mCustomerPhoneNumber;
            }
            set
            {
                //set the private data
                mCustomerPhoneNumber = value;
            }
        }

        //CustomerBillingAddress private member variable
        private string mCustomerBillingAddress;
        public string CustomerBillingAddress
        {
            get
            {
                //return the private data
                return mCustomerBillingAddress;
            }
            set
            {
                //set the private data
                mCustomerBillingAddress = value;
            }
        }

        //private date added data member
        private DateTime mDateOfRegistration;
        //public property for date added
        public DateTime DateOfRegistration
        {
            get
            {
                //return the private data
                return mDateOfRegistration;
            }
            set
            {
                //set the private data
                mDateOfRegistration = value;
            }
        }

        //private data member for isAllowed
        private Boolean mIsAllowed;

        //public property for IsAllowed
        public bool IsAllowed 
        {
            get
            {
                //return the private data
                return mIsAllowed;
            }
            set {
                //set the private data
                mIsAllowed = value;
            }
        }


        public bool Find(int CustomerId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer no to search for
            DB.AddParameter("@CustomerId", CustomerId);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //set the private data members to the test data value
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mDateOfRegistration = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfRegistration"]);
                mIsAllowed = Convert.ToBoolean(DB.DataTable.Rows[0]["IsAllowed"]);
                mCustomerPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["CustomerPhoneNumber"]);
                mCustomerBillingAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerBillingAddress"]);
                mCustomerFullName = Convert.ToString(DB.DataTable.Rows[0]["CustomerFullName"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }


          //  public string isAllowed(int CustoemrId, string CustomerFullName, string CustomerPhoneNumber, string CustomerBillingAddress )
          //  {
          //      return "";
         //   }
           //  throw new NotImplementedException();
        }
    }
}