using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mCustomerNo;
        public int CustomerNo
        {
            get {
                return mCustomerNo;
            }
            set {
                mCustomerNo = value;
            }
        }
        private string mCustomerName;
        public string CustomerName
        {
            get
            {
                return mCustomerName;
            }
            set 
            {
                mCustomerName = value;
            }
        }
        private string mCustomerEmail;
        public string CustomerEmail
        {
            get
            {
                return mCustomerEmail;
            }
            set
            {
                mCustomerEmail = value;
            }
        }
        private string mCustomerAddress;
        public string CustomerAddress
        {
            get
            {
                return mCustomerAddress;
            }
            set
            {
                mCustomerAddress = value;
            }
        }

        private DateTime mCustomerDateJoined;
        public DateTime CustomerDateJoined
        {
            get
            {
                return mCustomerDateJoined;
            }
            set 
            {
                mCustomerDateJoined = value;
            }
        }
        private bool mCustomerConfirmed;
        
        public bool CustomerConfirmed
        {
            get
            {
                return mCustomerConfirmed;
            }
            set
            {
                mCustomerConfirmed = value;
            }
        }

        public bool Find(int CustomerNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@CustomerNo", CustomerNo);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomers_FilterByCustomerNo");
            //if one recurd is found (there should be one or zero)
            if (DB.Count == 1)
            {
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mCustomerDateJoined = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerDateJoined"]);
                mCustomerConfirmed = Convert.ToBoolean(DB.DataTable.Rows[0]["CustomerConfirmed"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}