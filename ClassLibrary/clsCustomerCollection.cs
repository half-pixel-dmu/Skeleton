using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member thisCustomer#
        clsCustomer mThisCustomer = new clsCustomer();
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }

            set
            {
                //set the private data
                mCustomerList = value;
            }
        }
        public int Count 
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }

            set
            {
                
            }
        }
        public clsCustomer ThisCustomer 
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }

            set
            {
                //set the private data
                mThisCustomer = value;
            }

        }


        public clsCustomerCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stired oricedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of record
            RecordCount = DB.Count;
            //while there are record to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsCustomer AnCustomer = new clsCustomer();
                //read in the fields from the current record
                AnCustomer.CustomerConfirmed = Convert.ToBoolean(DB.DataTable.Rows[Index]["CustomerConfirmed"]);
                AnCustomer.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                AnCustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                AnCustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                AnCustomer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                AnCustomer.CustomerDateJoined = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerDateJoined"]);
                //add the record to the private data member
                mCustomerList.Add(AnCustomer);
                //point at the next record
                Index++;

            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@customerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@CustomerDateJoined", mThisCustomer.CustomerDateJoined);
            DB.AddParameter("@CustomerConfirmed", mThisCustomer.CustomerConfirmed);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerNo", mThisCustomer.CustomerNo);
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@CustomerDateJoined", mThisCustomer.CustomerDateJoined);
            DB.AddParameter("@CustomerConfirmed", mThisCustomer.CustomerConfirmed);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblCustomer_Update");
        }

    }


}