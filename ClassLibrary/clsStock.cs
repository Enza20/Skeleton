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

        private double mProductPrice;
        public double ProductPrice
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
                mProductPrice = Convert.ToDouble(DB.DataTable.Rows[0]["ProductPrice"]);
                mCanPurchase = Convert.ToBoolean(DB.DataTable.Rows[0]["CanPurchase"]);
                return true;
            }
            else
            {
                return false;
            }

        }

        public string Valid(int id, string description, int quantity, int supplierid, string expirydate, double price)
        {
            return "";
        }
    }
}