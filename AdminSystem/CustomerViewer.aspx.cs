﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();

        AnCustomer = (clsCustomer)Session["AnCustomer"];
        Response.Write(AnCustomer.CustomerName);
        Response.Write(AnCustomer.CustomerAddress);
        Response.Write(AnCustomer.CustomerEmail);
        Response.Write(AnCustomer.CustomerDateJoined);
    }
}