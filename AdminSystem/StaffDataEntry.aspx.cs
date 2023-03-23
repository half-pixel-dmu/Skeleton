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



    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        Int32 StaffNo;
        Boolean Found = false;
        StaffNo = Convert.ToInt32(txtStaffNo.Text);
        Found = AStaff.Find(StaffNo);
        if (Found == true)
        {
            txtStaffName.Text = AStaff.StaffName;
            txtStaffEmail.Text = AStaff.StaffEmail;
            txtStaffDate.Text = AStaff.StaffDate.ToString();
            txtProductNo.Text = AStaff.ProductNo.ToString();
            chkAvailability.Checked = AStaff.StaffAvailability;
        }
    }
}