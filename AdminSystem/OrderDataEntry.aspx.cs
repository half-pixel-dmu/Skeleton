using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{ 

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        Int32 OrderNo;
        Boolean Found = false;
        OrderNo = Convert.ToInt32(txtOrderNo.Text);
        Found = AnOrder.Find(OrderNo);
        if (Found == true)
        {
            txtCustomerNo.Text = AnOrder.CustomerNo.ToString();
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
            txtProductId.Text = AnOrder.ProductId.ToString();
            txtOrderPrice.Text = AnOrder.OrderPrice.ToString();
            txtOrderStatus.Text = AnOrder.OrderStatus;
        }
    }

    protected void btnCreate_Click1(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        string OrderNo = txtOrderNo.Text;
        string CustomerNo = txtCustomerNo.Text;
        string OrderDate = txtOrderDate.Text;
        string ProductId = txtProductId.Text;
        string OrderPrice = txtOrderPrice.Text;
        string OrderStatus = txtOrderStatus.Text;

        string Error = "";
        Error = AnOrder.Valid(CustomerNo, OrderDate, ProductId, OrderPrice, OrderStatus);
        if (Error == "")
        {
            AnOrder.OrderNo = Convert.ToInt32(OrderNo);
            AnOrder.CustomerNo = Convert.ToInt32(CustomerNo);
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            AnOrder.ProductId = Convert.ToInt32(ProductId);
            AnOrder.OrderPrice = Convert.ToInt32(OrderPrice);
            AnOrder.OrderStatus = OrderStatus;
            Session["AnOrder"] = AnOrder;
            Response.Write("OrderViewer.aspx");
       }
        else
        {
            lblError.Text = Error;
        }



        }
     void DisplayOrder()
    {
        // clsOrderCollection OrderBook = new clsOrderCollection();
        // OrderBook.ThisOrder.Find(1);
        // txtOrderNo.Text = OrderBook.ThisOrder.OrderNo.ToString();
        // txtCustomerNo.Text = OrderBook.ThisOrder.CustomerNo.ToString();
        // txtOrderDate.Text = OrderBook.ThisOrder.OrderDate.ToString();
        // txtProductId.Text = OrderBook.ThisOrder.ProductId.ToString();
        // txtOrderPrice.Text = OrderBook.ThisOrder.OrderPrice.ToString();
        // txtOrderStatus.Text = OrderBook.ThisOrder.OrderStatus.ToString();



    }

}