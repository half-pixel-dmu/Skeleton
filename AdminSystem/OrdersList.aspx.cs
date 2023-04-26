using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack == false)
        {
            DisplayOrder();
        }

    }
    void DisplayOrder()
    {
        clsOrderCollection Order = new clsOrderCollection();
        lstOrderLst.DataSource = Order.OrderList;
        lstOrderLst.DataValueField = "OrderNo";
        lstOrderLst.DataTextField = "Customer No";
        lstOrderLst.DataBind();
    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderNo"] = -1;
        Response.Redirect("OrderListEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderNo;
        if (lstOrderLst.SelectedIndex != -1)
        {
            OrderNo = Convert.ToInt32(lstOrderLst.SelectedValue);
            Session["OrderNo"] = OrderNo;
            Response.Redirect("OrderDataEntry.aspx");

        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderNo;
        if (lstOrderLst.SelectedIndex != -1)
        {
            OrderNo = Convert.ToInt32(lstOrderLst.SelectedValue);
            Session["OrderNo"] = OrderNo;
            Response.Redirect("AdressBookConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsOrderCollection Order = new clsOrderCollection();
        Order.ReportByOrderNo(TxtboxOrderNo.Text);
        lstOrderLst.DataSource = Order.OrderList;
        lstOrderLst.DataValueField = "OrderNo";
        lstOrderLst.DataTextField = "OrderNo";
        lstOrderLst.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsOrderCollection Order = new clsOrderCollection();
        Order.ReportByOrderNo("");
        TxtboxOrderNo.Text = "";
        lstOrderLst.DataSource = Order.OrderList;
        lstOrderLst.DataSource = Order.OrderList;
        lstOrderLst.DataValueField = "OrderNo";
        lstOrderLst.DataTextField = "OrderNo";
        lstOrderLst.DataBind();
    }
}