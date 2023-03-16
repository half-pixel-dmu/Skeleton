using System;
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
        //new instance of class
        clsStaff AStaff = new clsStaff();
        //get the data from the session object
        AStaff = (clsStaff)Session["AStaff"];
        //display staff name for this entry
        Response.Write(AStaff.StaffName);
        Response.Write(AStaff.StaffEmail);
        Response.Write(AStaff.StaffDate);
        Response.Write(AStaff.StaffAvailability);
        Response.Write(AStaff.ProductNo);
    }
}