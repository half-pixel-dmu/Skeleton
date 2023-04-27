using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsProductCollection
    {
        private List<clsProduct> mProductList = new List<clsProduct>();
        public List<clsProduct> ProductList
        {
            get
            {
                return mProductList;
            }
            set
            {
                mProductList = value;
            }
        }

        private int mCount;
        public int Count
        {
            get
            {
                return mProductList.Count;
            }
            set
            {
                // Worry about this later
            }
        }

        private clsProduct mThisProduct = new clsProduct();
        public clsProduct ThisProduct
        {
            get
            {
                return mThisProduct;
            }
            set
            {
                mThisProduct = value;
            }
        }

        public clsProductCollection() 
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblProducts_SelectAll");

            PopulateArray(DB);
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ProductTitle", mThisProduct.ProductTitle);
            DB.AddParameter("@ProductDescription", mThisProduct.ProductDescription);
            DB.AddParameter("@ProductPrice", mThisProduct.ProductPrice);
            DB.AddParameter("@ProductAvailability", mThisProduct.ProductAvailability);
            DB.AddParameter("@StaffNo", mThisProduct.StaffNo);

            return DB.Execute("sproc_tblProducts_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ProductNumber", mThisProduct.ProductNumber);
            DB.AddParameter("@ProductTitle", mThisProduct.ProductTitle);
            DB.AddParameter("@ProductDescription", mThisProduct.ProductDescription);
            DB.AddParameter("@ProductPrice", mThisProduct.ProductPrice);
            DB.AddParameter("@ProductAvailability", mThisProduct.ProductAvailability);
            DB.AddParameter("@StaffNo", mThisProduct.StaffNo);

            DB.Execute("sproc_tblProducts_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ProductNumber", mThisProduct.ProductNumber);

            DB.Execute("sproc_tblProducts_Delete");
        }

        public void ReportByProductTitle(string ProductTitle)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ProductTitle", ProductTitle);

            DB.Execute("sproc_tblProducts_FilterByProductTitle");

            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            int Index = 0;

            int RecordCount;

            RecordCount = DB.Count;

            mProductList = new List<clsProduct>();

            while (Index < RecordCount)
            {
                clsProduct AnProduct = new clsProduct();

                AnProduct.ProductNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductNumber"]);
                AnProduct.ProductTitle = Convert.ToString(DB.DataTable.Rows[Index]["ProductTitle"]);
                AnProduct.ProductDescription = Convert.ToString(DB.DataTable.Rows[Index]["ProductDescription"]);
                AnProduct.ProductPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["ProductPrice"]);
                AnProduct.ProductCreateDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ProductCreateDate"]);
                AnProduct.ProductAvailability = Convert.ToBoolean(DB.DataTable.Rows[Index]["ProductAvailability"]);
                AnProduct.StaffNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffNo"]);

                mProductList.Add(AnProduct);

                Index++;
            }
        }
    }
}