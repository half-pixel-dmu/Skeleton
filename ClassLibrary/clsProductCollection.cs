using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsProductCollection
    {
        private List<clsProduct> mProductList;
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

        private clsProduct mThisProduct;
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
            int Index = 0;
            
            int RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblProducts_SelectAll");

            RecordCount = DB.Count;

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

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            // TODO: create procedure and map fields correctly
            DB.AddParameter("@ProductTitle", mThisProduct.ProductTitle);
            DB.AddParameter("@ProductTitle", mThisProduct.ProductDescription);
            DB.AddParameter("@ProductTitle", mThisProduct.ProductPrice);
            DB.AddParameter("@ProductTitle", mThisProduct.ProductAvailability);
            DB.AddParameter("@ProductTitle", mThisProduct.StaffNo);

            return DB.Execute("sproc_tblProducts_Insert");
        }
    }
}