using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 StaffNo;
    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session objec

        StaffNo = Convert.ToInt32(Session["StaffNo"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the staff class
        clsStaffCollection Staff = new clsStaffCollection();
        //find the record to delete
        Staff.ThisStaff.Find(StaffNo);
        //delete the record
        Staff.Delete();
        //redirect
        Response.Redirect("StaffsList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffsList.aspx");
    }
}