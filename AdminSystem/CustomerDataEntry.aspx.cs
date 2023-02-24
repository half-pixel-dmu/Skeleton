using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture the full name
        AnCustomer.CustomerName = txtCustomerName.Text;
        AnCustomer.CustomerEmail = txtEmail.Text;
        AnCustomer.CustomerAddress = txtAddress.Text;
        AnCustomer.CustomerDateJoined = DateTime.Now.Date;

        //store the name in the session object
        Session["AnCustomer"] = AnCustomer;
        //navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }
}