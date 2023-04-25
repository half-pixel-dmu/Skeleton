using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //pricate data member for the staff no property
        private Int32 mStaffNo;
        private DateTime mStaffDate;
        private Int32 mProductNo;
        private string mStaffName;
        private string mStaffEmail;
        private Boolean mStaffAvailability;

        public int StaffNo 
        {
            get
            {
                //this line of code sends data our the property
                return mStaffNo;
            }
            set
            {
                //this line of code allows data into the property
                mStaffNo = value;
            }
        }
        public string StaffName 
        {
            get 
            {
                return mStaffName;
            }
            set
            {
                mStaffName = value;
            }
        }

        public string StaffEmail
        {
            get
            {
                return mStaffEmail;
            }
            set
            {
                mStaffEmail = value;
            }

        }
        public bool StaffAvailability 
        {
            get
            {
                return mStaffAvailability;
            }
            set
            {
                mStaffAvailability = value;
            }
        }
        public DateTime StaffDate
        { get
            {
                return mStaffDate;
            }
            set 
            {
                mStaffDate = value;
            } 
        }
        public int ProductNo
        {
            get
            {
                return mProductNo;
            }
            set
            {
                mProductNo = value;
            }
        }

        public bool Find(int StaffNo)
        {   
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@StaffNo", StaffNo);
            //execute the stored procedure
            DB.Execute("Sproc_tblStaff_FilterByStaffNo");
            //if one record is found
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffNo = Convert.ToInt32(DB.DataTable.Rows[0]["StaffNo"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mStaffEmail = Convert.ToString(DB.DataTable.Rows[0]["StaffEmail"]);
                mStaffAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["StaffAvailability"]);
                mStaffDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffDate"]);
                mProductNo = Convert.ToInt32(DB.DataTable.Rows[0]["ProductNo"]);
                //return that everything worked ok
                return true;
            }

            return false;
        }

        public string Valid(string staffName,
                            string staffEmail,
                            string staffDate,
                            string productNo)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the StaffName is blank
            if (staffName.Length == 0)
            {
                //record the error
                Error = Error + "The staff name may not be blank : ";
            }
            //if the StaffName is greater than 100 characters
            if (staffName.Length > 100)
            {
                Error = Error + "The Staff Name must be less than 100 characters : ";
            }
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(staffDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            //if the StaffEmail is blank
            if (staffEmail.Length == 0)
            {
                //record the error
                Error = Error + "The staff email may not be blank : ";
            }
            //if the StaffEmail is greater than 100 characters
            if (staffEmail.Length > 250)
            {
                Error = Error + "The Staff email must be less than 250 characters : ";
            }

            //if the ProductNo is blank
            if (productNo.Length == 0)
            {
                //record the error
                Error = Error + "The productNo may not be blank : ";
            }
            //return any error messages
            return Error;
        }
    }
}