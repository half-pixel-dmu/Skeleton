﻿using System;

namespace ClassLibrary
{
    public class clsProduct
    {   
        private int mProductNumber;
        public int ProductNumber { 
            get {
                return mProductNumber;
            } 
            set {
                mProductNumber = value;
            }
        }

        private string mProductTitle;
        public string ProductTitle {
            get
            {
                return mProductTitle;
            }
            set
            {
                mProductTitle = value;
            }
        }

        private string mProductDescription;
        public string ProductDescription {
            get
            {
                return mProductDescription;
            }
            set
            {
                mProductDescription = value;
            }
        }

        private double mProductPrice;
        public double ProductPrice {
            get
            {
                return mProductPrice;
            }
            set
            {
                mProductPrice = value;
            }
        }

        private DateTime mProductCreateDate;
        public DateTime ProductCreateDate {
            get
            {
                return mProductCreateDate;
            }
            set
            {
                mProductCreateDate = value;
            }
        }

        private bool mProductAvailability;
        public bool ProductAvailability {
            get
            {
                return mProductAvailability;
            }
            set
            {
                mProductAvailability = value;
            }
        }

        private int mStaffNo;
        public int StaffNo {
            get
            {
                return mStaffNo;
            }
            set
            {
                mStaffNo = value;
            }
        }

        public bool Find(int ProductNumber)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ProductNumber", ProductNumber);

            DB.Execute("sproc_tblProducts_FilterByProductNumber");

            if (DB.Count == 1)
            {
                mProductNumber = Convert.ToInt32(DB.DataTable.Rows[0]["ProductNumber"]);
                mProductTitle = Convert.ToString(DB.DataTable.Rows[0]["ProductTitle"]);
                mProductDescription = Convert.ToString(DB.DataTable.Rows[0]["ProductDescription"]);
                mProductPrice = Convert.ToDouble(DB.DataTable.Rows[0]["ProductPrice"]);
                mProductCreateDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ProductCreateDate"]);
                mProductAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["ProductAvailability"]);
                mStaffNo = Convert.ToInt32(DB.DataTable.Rows[0]["StaffNo"]);

                return true;
            }

            return false;
        }

        public string Valid(
            string productTitle,
            string productDescription,
            string productPrice,
            string staffNo
            ) 
        {
            String Error = "";

            if (productTitle.Length == 0)
            {
                Error = Error + "The product title may not be blank : ";
            }

            if (productTitle.Length > 250)
            {
                Error = Error + "The product title must be less than 250 characters : ";
            }

            if (productDescription.Length == 0)
            {
                Error = Error + "The product description may not be blank : ";
            }

            if (productDescription.Length > 250)
            {
                Error = Error + "The product description must be less than 250 characters : ";
            }

            try
            {
                if (Convert.ToDouble(productPrice).CompareTo(0) == 0)
                {
                    Error = Error + "The product price needs to be bigger than 0 : ";
                }

                if (Convert.ToDouble(productPrice).CompareTo(9999) > 0)
                {
                    Error = Error + "The product price must be less than 9999 : ";
                }
            } 
            catch
            {
                Error = Error + "The price was not valid : ";
            }

            try
            {
                if (Convert.ToInt32(staffNo) <= 0)
                {
                    Error = Error + "The staff number needs to be bigger than 0 : ";
                }
            }
            catch
            {
                Error = Error + "The staff number was not valid : ";
            }

            return Error;
        }
    }
}
