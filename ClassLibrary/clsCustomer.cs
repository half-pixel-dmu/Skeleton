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

        private DateTime mDateJoined;
        public DateTime CustomerDateJoined
        {
            get
            {
                return mDateJoined;
            }
            set 
            {
                mDateJoined = value;
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
            mCustomerNo = 1021;
            mCustomerName = "Test Name";
            mCustomerEmail = "Test email";
            mCustomerAddress = "This Street";
            mDateJoined = Convert.ToDateTime("16/09/2023");
            mCustomerConfirmed = true;
            return true;
        }
    }
}