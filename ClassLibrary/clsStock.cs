using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool Active { get; set; }

        public int ProductID { get; set; }
        
        public string Description { get; set; }

        public int Quantity { get; set; }

        public int SupplierID { get; set; }

        public DateTime ExpiryDate { get; set; }

        public double ProductPrice { get; set; }

        public bool CanPurchase { get; set; }

        public string Valid(int id, string description, int quantity, int supplierid, string expirydate, double price)
        {
            return "";
        }
    }
}