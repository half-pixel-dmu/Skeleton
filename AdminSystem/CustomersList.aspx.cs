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
        //if this is the first time the page is dispalyed
        if(IsPostBack == false)
        {
            //update the list box
            DisplayCustomer();
        }
    }

    void DisplayCustomer()
    {
        //create an instance of the Address collection
        clsCustomerCollection Customer = new clsCustomerCollection();
        //set the data source to list of addresses in the collection
        lstCustomerList.DataSource = Customer.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerNo";
        //set the data filed to display
        lstCustomerList.DataTextField = "CustomerAddress";
        //bind the data to the list
        lstCustomerList.DataBind();

    }

}