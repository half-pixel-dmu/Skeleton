using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductDataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsProduct anProduct = new clsProduct();

        int ProductNumber = Convert.ToInt32(txtProductNumber.Text);

        Boolean Found = anProduct.Find(ProductNumber);

        if (Found)
        {
            txtTitle.Text = anProduct.ProductTitle;
            txtDescription.Text = anProduct.ProductDescription;
            txtPrice.Text = anProduct.ProductPrice.ToString();
            chkAvailability.Checked = anProduct.ProductAvailability;
            txtStaff.Text = anProduct.StaffNo.ToString();
        }
    }

    protected void btnCreate_Click(object sender, EventArgs e)
    {
        clsProduct anProduct = new clsProduct();

        anProduct.ProductTitle = txtTitle.Text;
        anProduct.ProductDescription = txtDescription.Text;
        anProduct.ProductPrice = float.Parse(txtPrice.Text);
        anProduct.ProductAvailability = chkAvailability.Checked;
        anProduct.StaffNo = int.Parse(txtStaff.Text);

        Session["AnProduct"] = anProduct;

        // Navigate to view product page
        Response.Redirect("ProductViewer.aspx");
    }
}