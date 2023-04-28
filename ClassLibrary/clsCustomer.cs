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


          //  public string isAllowed(int CustomerId, string CustomerFullName, string CustomerPhoneNumber, string CustomerBillingAddress )
          //  {
          //      return "";
         //   }
           //  throw new NotImplementedException();
        }

        public string Valid(string customerFullName, string customerPhoneNumber, string customerBillingAddress, string dateOfRegistration)
        {
            //Create a string variable to store the error
            String Error =  "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the CustomerFullName is blank:
            if (customerFullName.Length == 0)
            {
                //record the error
                Error = Error + "The full name may not be blank :   ";

            }

            //if the full name is greater than 50 characters
            if (customerFullName.Length > 50)
            {
                //record the error
                Error = Error + "The full name must be 50 characters or less :      ";
            }

            try
            {
                //copy the dateOfRegistration value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateOfRegistration);

                //check to see if the date is less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past :   ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The data cannot be used in the future :    ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date :    ";
            }

            //if the customerPhoneNumber is blank:
            if (customerPhoneNumber.Length == 0)
            {
                //record the error
                Error = Error + "The phone number may not be blank :    ";

            }

            //if the phone number is greater than 15 characters
            if (customerPhoneNumber.Length > 15)
            {
                //record the error
                Error = Error + "The phone number must be 15 characters or less :   ";
            }


            //if the CustomerBillingAddress is blank:
            if (customerBillingAddress.Length == 0)
            {
                //record the error
                Error = Error + "The billing address may not be blank :     ";

            }

            //if the CustomerBillingAddress is greater than 50 characters
            if (customerBillingAddress.Length > 50)
            {
                //record the error
                Error = Error + "The billing address must be 50 characters or less :    ";
            }

            //return any error messages
            return Error;
        }

    /*    public static implicit operator List<object>(clsCustomer v)
        {
            throw new NotImplementedException();
        }
    */
    }
}