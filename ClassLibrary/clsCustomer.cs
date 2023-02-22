using System;

namespace ClassLibrary
{
    public class clsCustomer
    { 
        public bool IsAllowed { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public int CustomerId { get; set; }
        public string CustomerFullName { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerBillingAddress { get; set; }
       
    }
}