using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the pramary key with page level scope
    Int32 CustomerNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be processed
        CustomerNo = Convert.ToInt32(Session["CustomerNo"]);
        if(IsPostBack == false)
        {
            //if this is not a new record 
            if(CustomerNo != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
        }

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture the full name
        string CustomerName = txtCustomerName.Text;
        //capture the email
        string CustomerEmail = txtCustomerEmail.Text;
        //capture the address
        string CustomerAddress = txtCustomerAddress.Text;
        //capture the date joined
        string CustomerDateJoined = txtCustomerDateJoined.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);

        if (Error == "")
        {
            //capture the customer no
            AnCustomer.CustomerNo = CustomerNo;
            //capture the name
            AnCustomer.CustomerName = CustomerName;
            //capture the email
            AnCustomer.CustomerEmail = CustomerEmail;
            //capture the address
            AnCustomer.CustomerAddress = CustomerAddress;
            //capture the date joined
            AnCustomer.CustomerDateJoined = Convert.ToDateTime(CustomerDateJoined);
            //capture if the customer is confirmed
            AnCustomer.CustomerConfirmed = chkActive.Checked;
            //create a new instance of the address collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            //if this is a new record i.e. CustomerNo = -1 then add the data
            if (CustomerNo == -1)
            {
                //set the ThisAddress property
                CustomerList.ThisCustomer = AnCustomer;
                //add the new record
                CustomerList.Add();
            
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(CustomerNo);
                //set the ThisAddress property
                CustomerList.ThisCustomer = AnCustomer;
                //update the record
                CustomerList.Update();
            }
            //redirect back to the listpage
            Response.Redirect("CustomersList.aspx");
        }
        else
        {
            //display the error message
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

    void DisplayCustomer()
    {
        //create an instance of the address book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to update
        CustomerBook.ThisCustomer.Find(CustomerNo);
        //display the data for this record
        txtCustomerNo.Text = CustomerBook.ThisCustomer.CustomerNo.ToString();
        txtCustomerName.Text = CustomerBook.ThisCustomer.CustomerName;
        txtCustomerEmail.Text = CustomerBook.ThisCustomer.CustomerEmail;
        txtCustomerAddress.Text = CustomerBook.ThisCustomer.CustomerAddress;
        txtCustomerDateJoined.Text = CustomerBook.ThisCustomer.CustomerDateJoined.ToString();
        chkActive.Checked = CustomerBook.ThisCustomer.CustomerConfirmed; 
    }
}