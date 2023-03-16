using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            // mProductNumber = 14;
            // mProductTitle = "Cleaning service";
            // mProductDescription = "Spot on cleaning details";
            // mProductPrice = 12;
            // mProductCreateDate = Convert.ToDateTime("14/03/2023");
            // mProductAvailability = true;
            // mStaffNo = 6;

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
    }
}
