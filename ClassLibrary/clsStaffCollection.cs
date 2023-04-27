using System;
using System.Collections.Generic;

namespace ClassLibrary

{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member for thisStaff
        clsStaff mThisStaff = new clsStaff();

        public List<clsStaff> StaffList
        { 
            get 
            {
                //return the private data
                return mStaffList;
            }
            set 
            {
                //set the private data
                mStaffList = value;
            } 
        }

        public int Count { 
            get
            {
                //return the count
                return mStaffList.Count;
            }
            set 
            {
                //lol
            } 
        }

        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }

        public clsStaffCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the database based on the value of mThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("@StaffAvailability", mThisStaff.StaffAvailability);
            DB.AddParameter("@StaffDate", mThisStaff.StaffDate);
            DB.AddParameter("@ProductNo", mThisStaff.ProductNo);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");

        }

        public void Update()
        {
            //update an existing record
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffNo", mThisStaff.StaffNo);
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("@StaffAvailability", mThisStaff.StaffAvailability);
            DB.AddParameter("@StaffDate", mThisStaff.StaffDate);
            DB.AddParameter("@ProductNo", mThisStaff.ProductNo);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblStaff_Update");

        }

        public void Delete()
        {
            //deletes the record pointed to by thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffNo", mThisStaff.StaffNo);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByName(String StaffName)
        {
            //filters the records based on a full or partial name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the name parameter to the database
            DB.AddParameter("@StaffName", StaffName);
            //execute the store procedure
            DB.Execute("sproc_tblStaff_FilterByName");
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
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //ccreate a blank staff
                clsStaff AStaff = new clsStaff();
                //read in the fields from the current record
                AStaff.StaffAvailability = Convert.ToBoolean(DB.DataTable.Rows[Index]["StaffAvailability"]);
                AStaff.StaffNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffNo"]);
                AStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                AStaff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["StaffEmail"]);
                AStaff.StaffDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StaffDate"]);
                AStaff.ProductNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductNo"]);
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //point at the next record
                Index++;
            }
        }

    }
}