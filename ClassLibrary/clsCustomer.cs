using System;

namespace ClassLibrary
{
    public class clsCustomer
    { 
        public bool IsAllowed { get; set; }
        public DateTime DateOfRegistration { get; set; }

        //addressNo private memebr variable
        private Int32 mCustomerId;
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
        public string CustomerFullName { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerBillingAddress { get; set; }

        public bool Find(int customerNo)
        {
            // throw new NotImplementedException();

            //set the private data members to the test data value
            mCustomerId = 200503;
            //always return true
            return true;
        }
    }
}