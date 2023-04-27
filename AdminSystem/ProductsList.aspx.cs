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
        if (IsPostBack == false)
        {
            DisplayProducts();
        }
    }

    void DisplayProducts()
    {
        clsProductCollection Products = new clsProductCollection();

        lstProductsList.DataSource = Products.ProductList;
        
        lstProductsList.DataValueField = "ProductNumber";
        
        lstProductsList.DataTextField = "ProductTitle";
        
        lstProductsList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ProductNumber"] = -1;

        Response.Redirect("ProductDataEntry.aspx");
    }
    
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        int ProductNumber;

        if (lstProductsList.SelectedIndex != -1)
        {
            ProductNumber = Convert.ToInt32(lstProductsList.SelectedValue);

            Session["ProductNumber"] = ProductNumber;

            Response.Redirect("ProductDataEntry.aspx");
        } 
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        int ProductNumber;

        if (lstProductsList.SelectedIndex != -1)
        {
            ProductNumber = Convert.ToInt32(lstProductsList.SelectedValue);

            Session["ProductNumber"] = ProductNumber;

            Response.Redirect("ProductConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsProductCollection Products = new clsProductCollection();

        Products.ReportByProductTitle(txtProductTitle.Text);

        lstProductsList.DataSource = Products.ProductList;

        lstProductsList.DataValueField = "ProductNumber";

        lstProductsList.DataTextField = "ProductTitle";

        lstProductsList.DataBind();

    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtProductTitle.Text = "";

        clsProductCollection Products = new clsProductCollection();

        Products.ReportByProductTitle("");

        lstProductsList.DataSource = Products.ProductList;

        lstProductsList.DataValueField = "ProductNumber";

        lstProductsList.DataTextField = "ProductTitle";

        lstProductsList.DataBind();
    }
}