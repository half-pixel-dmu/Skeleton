using ClassLibrary;
using System;

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
        
        string ProductTitle = txtTitle.Text;
        string ProductDescription = txtDescription.Text;
        string ProductPrice = txtPrice.Text;
        string StaffNo = txtStaff.Text;

        string Error = "";

        Error = anProduct.Valid(ProductTitle, ProductDescription, ProductPrice, StaffNo);

        if (Error == "")
        {
            anProduct.ProductTitle = ProductTitle;
            anProduct.ProductDescription = ProductDescription;
            anProduct.ProductPrice = Convert.ToDouble(ProductPrice);
            anProduct.ProductAvailability = chkAvailability.Checked;
            anProduct.StaffNo = int.Parse(StaffNo);

            // Session["AnProduct"] = anProduct;

            clsProductCollection ProductList = new clsProductCollection();

            ProductList.ThisProduct = anProduct;

            ProductList.Add();

            // Navigate to view product page
            Response.Redirect("ProductsList.aspx");
        } 
        else
        {
            // Display the error message to the user
            lblError.Text = Error;
        }
    }
}