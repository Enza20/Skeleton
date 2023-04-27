using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        //private data member thisStaff
        clsStock mThisStock = new clsStock();

        //constructor for the class
        public clsStockCollection()
        {
           
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //populate the array list with the data table
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
            mStockList = new List<clsStock>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff
                clsStock Stock = new clsStock();
                //read in the fields from the current record
                Stock.CanPurchase = Convert.ToBoolean(DB.DataTable.Rows[Index]["CanPurchase"]);
                Stock.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                Stock.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                Stock.ExpiryDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ExpiryDate"]);
                Stock.ProductPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["ProductPrice"]);
                Stock.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                Stock.SupplierID = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierID"]);

                //add the record to the private data member
                mStockList.Add(Stock);
                //point at the next record
                Index++;

            }
        }

        //public property for the staff list
        public List<clsStock> StockList
        {
            get
            {
                //return the private data
                return mStockList;
            }
            set
            {
                //set the private data
                mStockList = value;
            }
        }
        
        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mStockList.Count;

            }
            set
            {
                //later
            }
        }

        //public property for ThisStaff
        public clsStock ThisStock
        {
            get
            {
                //return the private data
                return mThisStock;
            }
            set
            {
                //set the private data
                mThisStock = value;
            }
        }


        public int Add()
        {
            //adds a new record to the database based on the values of thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Description", mThisStock.Description);
            DB.AddParameter("@Quantity", mThisStock.Quantity);
            DB.AddParameter("@CanPurchase", mThisStock.CanPurchase);
            DB.AddParameter("@ExpiryDate", mThisStock.ExpiryDate);
            DB.AddParameter("@ProductPrice", mThisStock.ProductPrice);
            DB.AddParameter("@SupplierID", mThisStock.SupplierID);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStock_Insert");
        }


        public void Update()
        {
            //update an existing record based on the values of thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedures
            DB.AddParameter("@Description", mThisStock.Description);
            DB.AddParameter("@Quantity", mThisStock.Quantity);
            DB.AddParameter("@CanPurchase", mThisStock.CanPurchase);
            DB.AddParameter("@ExpiryDate", mThisStock.ExpiryDate);
            DB.AddParameter("@ProductPrice", mThisStock.ProductPrice);
            DB.AddParameter("@SupplierID", mThisStock.SupplierID);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Update");

        }


        public void Delete()
        {
            //deletes the record pointed to by thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ProductID", mThisStock.ProductID);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Delete");
        }

       




       
       

        public void ReportByDescription(string Description)
        {
            //filters the records based on a full or partial name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the FullName parameter to the database
            DB.AddParameter("@Description", Description);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByDescription");
            //populate the array list with the data table
            PopulateArray(DB);
            
               
        }


    }


}