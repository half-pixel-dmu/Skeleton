using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsProduct anProduct = (clsProduct)Session["AnProduct"];

        lblNumber.Text = anProduct.ProductNumber.ToString();
        lblTitle.Text = anProduct.ProductTitle;
        lblDescription.Text = anProduct.ProductDescription;
        lblPrice.Text = anProduct.ProductPrice.ToString();
        lblAvailability.Text = anProduct.ProductAvailability.ToString();
        lblCreateDate.Text = anProduct.ProductCreateDate.ToString();
        lblStaffNo.Text = anProduct.StaffNo.ToString();
    }
}