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

        private float mProductPrice;
        public float ProductPrice {
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

        public bool Find(int productNo)
        {
            mProductNumber = 14;
            mProductTitle = "Cleaning service";
            mProductDescription = "Spot on cleaning details";
            mProductPrice = 12;
            mProductCreateDate = Convert.ToDateTime("14/03/2023");
            mProductAvailability = true;
            mStaffNo = 6;

            return true;
        }
    }
}
