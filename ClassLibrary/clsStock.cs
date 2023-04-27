using System;

namespace ClassLibrary
{
    public class clsStock
    {
        private Int32 mProductID;

        public bool Active { get; set; }

        public Int32 ProductID
        {
            get
            {
                return mProductID;
            }
            set
            {
                mProductID = value;
            }
        }

        private string mDescription;
        public string Description
        {
            get
            {
                return mDescription;
            }

            set
            {
                mDescription = value;
            }
        }

        private Int32 mQuantity;
        public Int32 Quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }

        private Int32 mSupplierID;
        public Int32 SupplierID
        {
            get
            {
                return mSupplierID;
            }
            set
            {
                mSupplierID = value;
            }
        }

        private DateTime mExpiryDate;
        public DateTime ExpiryDate
        {
            get
            {
                return mExpiryDate;
            }
            set
            {
                mExpiryDate = value;
            }
        }

        private decimal mProductPrice;
        public decimal ProductPrice
        {
            get
            {
                return mProductPrice;
            }
            set
            {
                mProductPrice = value;
            }
        }

        private bool mCanPurchase;
        public bool CanPurchase
        {
            get
            {
                return mCanPurchase;
            }
            set
            {
                mCanPurchase = value;
            }
        }

        public bool Find(int ProductID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", ProductID);
            DB.Execute("sproc_tblStock_FilterByProductID");
            if(DB.Count == 1)
            {
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mSupplierID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                mExpiryDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ExpiryDate"]);
                mProductPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["ProductPrice"]);
                mCanPurchase = Convert.ToBoolean(DB.DataTable.Rows[0]["CanPurchase"]);
                return true;
            }
            else
            {
                return false;
            }

        }

        public string Valid(string description, int quantity, int supplierid, string expirydate, decimal price)
        {
            String Error = "";
            DateTime DateTemp;
            if(description.Length > 500)
            {
                Error = Error + "The maximum lenght of description is 500 characters. ";
            }

            try
            {
                if (quantity < 0)
                {
                    Error = Error + "Quantity cannot be negative number. ";
                }

                if (quantity > 10000)
                {
                    Error = Error + "Quantity cannot be greater than 10000. ";
                }
            }
            catch
            {
                Error = Error + "Invalid quantity format. ";
            }

            try
            {
                if (supplierid < 1)
                {
                    Error = Error + "SupplierID cannot be less than 1. ";
                }

                if (supplierid > 1000)
                {
                    Error = Error + "Maximum number of SupplierID is 1000. ";
                }
            }
            catch
            {
                Error = Error + "Invalid SupplierID format. ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(expirydate);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past. ";
                }

                DateTime MaxExpiryDate;
                MaxExpiryDate = DateTime.Now.Date;
                MaxExpiryDate = MaxExpiryDate.AddYears(20);
                if (DateTemp > MaxExpiryDate)
                {
                    Error = Error + "Maximum date is 20 years in the future from today. ";
                }
            }
            catch
            {
                Error = Error + "Invalid date format. ";
            }

            try
            {
                if (price < 0.01m)
                {
                    Error = Error + "Price can not be 0 or less. ";
                }
                if (price > 9999.99m)
                {
                    Error = Error + "Maximum price is 9999.99";
                }
            }
            catch
            {
                Error = Error + "Invalid price format. ";
            }


            return Error;
        }
    }
}