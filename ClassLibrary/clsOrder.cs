using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsOrder
    {
        private int mOrderNo;
        public int OrderNo
        {
            get
            {
                return mOrderNo;
            }
            set
            {
                mOrderNo = value;
            }
        }

        private int mCustomerNo;
        public int CustomerNo
        {
            get
            {
                return mCustomerNo;
            }
            set
            {
                mCustomerNo = value;
            }
        }

        private DateTime mOrderDate;
        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        }

        private int mProductId;
        public int ProductId
        {
            get
            {
                return mProductId;
            }
            set
            {
                mProductId = value;
            }
        }

        private decimal mOrderPrice;
        public decimal OrderPrice
        {
            get
            {
                return mOrderPrice;
            }
            set
            {
                mOrderPrice = value;
            }
        }

        private string mOrderStatus;
        public string OrderStatus
        {
            get
            {
                return mOrderStatus;
            }
            set
            {
                mOrderStatus = value;
            }
        }

        public bool Find(int OrderNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@OrderNo", OrderNo);
            //execute the stored procedure
            DB.Execute("Sproc_tblOrder_FilterByOrderNo");
            //if one record is found
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members

                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mProductId = Convert.ToInt32(DB.DataTable.Rows[0]["ProductId"]);
                mOrderPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["OrderPrice"]);
                mOrderStatus = Convert.ToString(DB.DataTable.Rows[0]["OrderStatus"]);
                //return that everything worked ok
                return true;
            }

            return false;
        }
        public string Valid(string CustomerNo,
                            string OrderDate,
                            string ProductId,
                            string OrderPrice,
                            string OrderStatus)
        {
            //create a variable to store a error
            String Error = "";
            //create a temporary variable
            DateTime DateTemp;
            if (CustomerNo.Length == 0)
            {
                Error = Error + "The customer number may not be blank:";
            }
            if (CustomerNo.Length > 100)
            {
                Error = Error + "The customer number mest be less than 100 characters: ";
            }
            try
            {
                DateTemp = Convert.ToDateTime(OrderDate);
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future:";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date:";
            }
            if (ProductId.Length == 0)
            {
                Error = Error + "The Product Id may not be blank : ";
            }
            if (ProductId.Length > 50)
            {
                Error = Error + "The Product id must be less than 50 characters : ";
            }
            if (OrderPrice.Length == 0)
            {
                Error = Error + "The product cannot be free";

            }
            if (OrderStatus.Length == 0)
            {
                Error = Error + "The order need to present a status";
            }
            return Error;
        }

        public string Valid(string customerNo, string orderDate, string productId, string orderPrice, object orderStatus)
        {
            return "";
        }
    }
}