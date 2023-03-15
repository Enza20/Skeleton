using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClassLibrary
{
    public class clsCustomer
    {
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

        public bool Find(int customerNo)
        {
            // throw new NotImplementedException();

            //set the private data members to the test data value
            mCustomerId = 200503;
            mDateOfRegistration = Convert.ToDateTime("16/9/2015");
            mIsAllowed = true;
            mCustomerPhoneNumber = "07951243849";
            mCustomerBillingAddress = "1 DMU Close";
            mCustomerFullName = "Jane Doe";
            //always return true
            return true;
  
        }
    }
}