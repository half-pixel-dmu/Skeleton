using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCreate_Click(object sender, EventArgs e)
    {
        clsOrder anOrder = new clsOrder();

        anOrder.OrderNo = int.Parse(txtOrderNo.Text);
        anOrder.CustomerNo = int.Parse(txtCustomerNo.Text);
        anOrder.OrderDate = DateTime.Parse(txtOrderDate.Text);
        anOrder.ProductId = int.Parse(txtProductId.Text);
        anOrder.OrderPrice = int.Parse(txtOrderPrice.Text);
        anOrder.OrderStatus = txtOrderStatus.Text;

        Session["AnOrder"] = anOrder;

        // Navigate to view product page
        Response.Redirect("OrderViewer.aspx");
    }
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
}
