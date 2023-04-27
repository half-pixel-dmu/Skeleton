using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        clsOrder mThisOrder = new clsOrder();


        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }
        public int Count { get; set; }
        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }
        List<clsOrder> mOrderList = new List<clsOrder>();
        public clsOrderCollection()
        {
            clsOrder TestItem = new clsOrder();
            TestItem.OrderNo = 1;
            TestItem.CustomerNo = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ProductId = 1;
            TestItem.OrderPrice = 2;
            TestItem.OrderStatus = "Some Status";
            mOrderList.Add(TestItem);
            TestItem = new clsOrder();
            TestItem.OrderNo = 2;
            TestItem.CustomerNo = 2;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ProductId = 2;
            TestItem.OrderPrice = 3;
            TestItem.OrderStatus = "Different status";
            mOrderList.Add(TestItem);
        }

        public int Add()
        {
            mThisOrder.OrderNo = 123;
            return mThisOrder.OrderNo;
        }

        public void Update()
        {

        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByOrderNo(string OrderNo)
        {
         
        }
    }
}
