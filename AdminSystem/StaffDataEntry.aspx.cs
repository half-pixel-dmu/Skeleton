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
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //capture the staff no
        AStaff.StaffName = txtStaffName.Text;
        AStaff.StaffEmail = txtStaffEmail.Text;
        AStaff.StaffDate = DateTime.Now.Date;
        AStaff.StaffAvailability = chkAvailability.Checked;
        AStaff.ProductNo = int.Parse(txtProductNo.Text);
        //store the staff in the session object
        Session["AStaff"] = AStaff;
        //navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");
    }


}