using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for the staff id
        private Int32 mStaffId;

        private DateTime mDate;
        private string mFullName;
        private string mRole;
        private Boolean mActive;
        private decimal mSalary;

        //active public property
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }
        }

        //employment date public property
        public DateTime Date
        {
            get
            {
                return mDate;
            }
            set
            {
                mDate = value;
            }
        }

 

        //StaffId public property

        public Int32 StaffId
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffId;
            }
            set
            {
                //this line of code allows data into the property
                mStaffId = value;
            }
        }

  

        public string FullName
        {
            get
            {
                //return private data
                return mFullName;
            }
            set
            {
                //set the private data
                mFullName = value;
            }
        }


        public decimal Salary
        {
            get
            {
                //return private data
                return mSalary;
            }
            set
            {
                //set the private data
                mSalary = value;
            }
        }
        public string Role
        {
            get
            {
                //return private date
                return mRole;
            }
            set
            {
                //set the private data
                mRole = value;
            }
        }
       

        public bool Find(int staffId)
        {
            //set the private data members to the test data value
            mStaffId = 1;
            mDate = Convert.ToDateTime("17/01/2017");
            mFullName = "Trevor Potts";
            mRole = "Manager";
            mActive = true;
            //mSalary = 27.55;


            //always return true
            return true;
        }








    }
}