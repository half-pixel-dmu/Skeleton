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

}