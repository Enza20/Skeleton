using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        private DateTime mDateOfRegistration;
        public DateTime DateOfRegistration {
            get
            {
                return mDateOfRegistration;
            }
            set
            {
                mDateOfRegistration = value;
            }
        }

        private Boolean mSupplierActive;
        public bool SupplierActive
        {
            get
            {
                return mSupplierActive;
            }
            set
            {
                mSupplierActive = value;
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
        private string mSupplierCompanyName;
        public string SupplierCompanyName {
            get
            {
                return mSupplierCompanyName;
            }
            set
            {
                mSupplierCompanyName = value;
            }
        }
        private string mSupplierPhoneNumber;
        public string SupplierPhoneNumber {
            get
            {
                return mSupplierPhoneNumber;
            }
            set
            {
                mSupplierPhoneNumber = value;
            }
        }
        private string mSupplierVatNumber;
        public string SupplierVatNumber {
            get
            {
                return mSupplierVatNumber;
            }
            set
            {
                mSupplierVatNumber = value;
            }
        }
        private string mSupplierDeliveryDay;
        public string SupplierDeliveryDay {
            get
            {
                return mSupplierDeliveryDay;
            }
            set
            {
                mSupplierDeliveryDay = value;
            }
        }
        public bool Find(int SupplierID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierID", SupplierID);
            DB.Execute("sproc_tblSupplier_FilterBySupplierID");
            if (DB.Count == 1)
            {
                mSupplierID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                mSupplierCompanyName = Convert.ToString(DB.DataTable.Rows[0]["SupplierCompanyName"]);
                mSupplierPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["SupplierPhoneNumber"]);
                mSupplierVatNumber = Convert.ToString(DB.DataTable.Rows[0]["SupplierVatNumber"]);
                mDateOfRegistration = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfRegistration"]);
                mSupplierDeliveryDay = Convert.ToString(DB.DataTable.Rows[0]["SupplierDeliveryDay"]);
                mSupplierActive = Convert.ToBoolean(DB.DataTable.Rows[0]["SupplierActive"]);
                return true;
            }
            else
            {
                return false;
            }

        }

        public string Valid(string supplierCompanyName, string supplierPhoneNumber, string supplierVatNumber, string dateOfRegistration, string supplierDeliveryDay)
        {
        String Error = "";
            DateTime DateT;
            if (supplierCompanyName.Length == 0)
            {
                Error = Error + "Company name may not be blank : ";
            }

            if (supplierCompanyName.Length > 50)
            {
                Error = Error + "Company name must be less than 51 characters : ";
            }

            try
            {
                DateT = Convert.ToDateTime(dateOfRegistration);

                if (DateT < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateT > DateTime.Now.Date)
                {
                    Error = Error + "The data cannot be used in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }

            if (supplierPhoneNumber.Length == 0)
            {
                Error = Error + "Phone number must have digits : ";

            }

            if (supplierPhoneNumber.Length > 16)
            {
                Error = Error + "Phone number must be less than 17 characters : ";
            }


            if (supplierVatNumber.Length == 0)
            {
                Error = Error + "VAT number must be more than 0 characters : ";

            }

            if (supplierVatNumber.Length > 17)
            {
                Error = Error + "VAT number must be less than 18 characters : ";
            }

            if (supplierDeliveryDay.Length == 0)
            {
                Error = Error + "Delivery day must be more than 0 characters : ";

            }

            if (supplierDeliveryDay.Length > 20)
            {
                Error = Error + "Deilvery day must be less than 21 characters : ";
            }



            return Error;
        }


    }
}