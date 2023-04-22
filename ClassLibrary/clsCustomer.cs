using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for street
        private Int32 mCustomerNo;
        //public data member for street
        public int CustomerNo
        {
            get 
            {
                //return the private data
                return mCustomerNo;
            }
            set 
            {
                //set the private data
                mCustomerNo = value;
            }
        }
        //private data member for street
        private string mCustomerName;
        //private data member for street
        public string CustomerName
        {
            get
            {
                //return the private data
                return mCustomerName;
            }
            set 
            {
                //set the private data
                mCustomerName = value;
            }
        }
        //private data member for street
        private string mCustomerEmail;
        //private data member for street
        public string CustomerEmail
        {
            get
            {
                //return the private data
                return mCustomerEmail;
            }
            set
            {
                //set the private data
                mCustomerEmail = value;
            }
        }
        //private data member for street
        private string mCustomerAddress;
        //private data member for street
        public string CustomerAddress
        {
            get
            {
                //return the private data
                return mCustomerAddress;
            }
            set
            {
                //set the private data
                mCustomerAddress = value;
            }
        }
        //private data member for street
        private DateTime mCustomerDateJoined;
        //private data member for street
        public DateTime CustomerDateJoined
        {
            get
            {
                //return the private data
                return mCustomerDateJoined;
            }
            set 
            {
                //set the private data
                mCustomerDateJoined = value;
            }
        }
        //private data member for street
        private bool mCustomerConfirmed;
        //private data member for street
        public bool CustomerConfirmed
        {
            get
            {
                //return the private data
                return mCustomerConfirmed;
            }
            set
            {
                //set the private data
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
                //copy the data from the database to the private data members
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mCustomerDateJoined = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerDateJoined"]);
                mCustomerConfirmed = Convert.ToBoolean(DB.DataTable.Rows[0]["CustomerConfirmed"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }

        }

        public string Valid(string customerName, string customerEmail, string customerAddress, string customerDateJoined)
        {
            //crate a string variable to store the error
            String Error = "";
            //crate a temporary variable to store date values
            DateTime DateTemp;
            //if the customerName is blank
            if( customerName.Length == 0)
            {
                //record the error
                Error = Error + "The customer name may not be blank ";
            }
            //if the cusotmer name is grater than 250 characters
            if(customerName.Length > 250)
            {
                //record the error
                Error = Error + "The customer name must be less than 250 characters ";
            }
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(customerDateJoined);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if th date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            //is the post code blank
            if(customerAddress.Length == 0)
            {
                //record the error
                Error = Error + "The address may not be blank : ";
            }
            //if the customer address excedes 250 characters
            if(customerAddress.Length > 250)
            {
                //record the error
                Error = Error + "The address must be less than 250 characters : ";
            }
            //if the code is blank
            if (customerEmail.Length == 0)
            {
                //record the error
                Error = Error + "The email may not be blank : ";
            }
            //if the customer email excedes 250 characters 
            if (customerEmail.Length > 250)
            {
                //record the error
                Error = Error + "The email must be less than 250 characters : ";
            }
            //return any error messages
            return Error;
        }
    }
}