using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    int ProductNumber;
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductNumber = Convert.ToInt32(Session["ProductNumber"]);

        lblProductNumber.Text = ProductNumber.ToString();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsProductCollection Products = new clsProductCollection();

        Products.ThisProduct.Find(ProductNumber);

        Products.Delete();

        Response.Redirect("ProductsList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProductsList.aspx");
    }
}