using ClassLibrary;
using System;

public partial class ProductDataEntry : System.Web.UI.Page
{
    int ProductNumber;
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductNumber = Convert.ToInt32(Session["ProductNumber"]);

        if (IsPostBack == false)
        {
            if (ProductNumber != -1)
            {
                DisplayProduct();
            }
        }
    }

    void DisplayProduct()
    {
        clsProductCollection Products = new clsProductCollection();

        Products.ThisProduct.Find(ProductNumber);

        txtProductNumber.Text = Products.ThisProduct.ProductNumber.ToString();
        txtTitle.Text = Products.ThisProduct.ProductTitle;
        txtDescription.Text = Products.ThisProduct.ProductDescription;
        txtPrice.Text = Products.ThisProduct.ProductPrice.ToString();
        chkAvailability.Checked = Products.ThisProduct.ProductAvailability;
        txtStaff.Text = Products.ThisProduct.StaffNo.ToString();
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
            anProduct.ProductNumber = ProductNumber;
            anProduct.ProductTitle = ProductTitle;
            anProduct.ProductDescription = ProductDescription;
            anProduct.ProductPrice = Convert.ToDouble(ProductPrice);
            anProduct.ProductAvailability = chkAvailability.Checked;
            anProduct.StaffNo = int.Parse(StaffNo);

            // Session["AnProduct"] = anProduct;

            clsProductCollection ProductList = new clsProductCollection();

            if (ProductNumber == -1)
            {
                // Create a new product
                ProductList.ThisProduct = anProduct;

                ProductList.Add();
            } 
            else
            {
                // Update aproduct
                ProductList.ThisProduct.Find(ProductNumber);

                ProductList.ThisProduct = anProduct;

                ProductList.Update();
            }

            // Navigate to view product page
            Response.Redirect("ProductsList.aspx");
        } 
        else
        {
            // Display the error message to the user
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProductsList.aspx");
    }
}