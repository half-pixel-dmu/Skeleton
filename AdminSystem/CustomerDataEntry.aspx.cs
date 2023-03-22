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


    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture the full name

        string CustomerName = txtCustomerName.Text;
        string CustomerEmail = txtCustomerEmail.Text;
        string CustomerAddress = txtCustomerAddress.Text;
        string CustomerDateJoined = txtCustomerDateJoined.Text;

        string Error = "";
        Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);

        if (Error == "")
        {
            AnCustomer.CustomerName = CustomerName;
            AnCustomer.CustomerEmail = CustomerEmail;
            AnCustomer.CustomerAddress = CustomerAddress;
            AnCustomer.CustomerDateJoined = Convert.ToDateTime(CustomerDateJoined);
            AnCustomer.CustomerConfirmed = chkActive.Checked;

            //store the name in the session object
            Session["AnCustomer"] = AnCustomer;
            //navigate to the viewer page
            Response.Redirect("CustomerViewer.aspx");
        }

        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();
        Int32 CustomerNo;
        Boolean Found = false;
        CustomerNo = Convert.ToInt32(txtCustomerNo.Text);
        Found = AnCustomer.Find(CustomerNo);
        if(Found == true)
        {
            txtCustomerName.Text = AnCustomer.CustomerName;
            txtCustomerEmail.Text = AnCustomer.CustomerEmail;
            txtCustomerAddress.Text = AnCustomer.CustomerAddress;
            txtCustomerDateJoined.Text = AnCustomer.CustomerDateJoined.ToString();
            chkActive.Checked = AnCustomer.CustomerConfirmed;
            
        }
    }
}