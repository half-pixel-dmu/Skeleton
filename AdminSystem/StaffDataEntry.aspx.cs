using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 StaffNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the staff to be processed
        StaffNo = Convert.ToInt32(Session["StaffNo"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (StaffNo != -1)
            {
                //display current data
                DisplayStaff();
            }
        }

    }

    private void DisplayStaff()
    {
        //create an instance of the staff
        clsStaffCollection Staff = new clsStaffCollection();
        //find the record to update
        Staff.ThisStaff.Find(StaffNo);
        //display the data for this record
        txtStaffNo.Text = Staff.ThisStaff.StaffNo.ToString();
        txtStaffName.Text = Staff.ThisStaff.StaffName;
        txtStaffEmail.Text = Staff.ThisStaff.StaffEmail;
        txtStaffDate.Text = Staff.ThisStaff.StaffDate.ToString();
        txtProductNo.Text = Staff.ThisStaff.ProductNo.ToString();
        chkAvailability.Checked = Staff.ThisStaff.StaffAvailability;

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        {
            //create a new instance of clsStaff
            clsStaff AStaff = new clsStaff();
            //capture the staff details
            string StaffName = txtStaffName.Text;
            string StaffEmail = txtStaffEmail.Text;
            string StaffDate = txtStaffDate.Text;
            string ProductNo = txtProductNo.Text;
            //variable to store any error messages
            string Error = "";
            //validate the data
            Error = AStaff.Valid(StaffName, StaffEmail, StaffDate, ProductNo);
            if (Error == "")
            {
                AStaff.StaffNo = StaffNo;
                //capture details
                AStaff.StaffName = StaffName;
                AStaff.StaffEmail = StaffEmail;
                AStaff.StaffDate = Convert.ToDateTime(StaffDate);
                AStaff.ProductNo = Convert.ToInt32(ProductNo);
                AStaff.StaffAvailability = chkAvailability.Checked;
                //create a new instance of the staff collection
                clsStaffCollection StaffList = new clsStaffCollection();
                
                //if this is a new record 
                if (StaffNo == -1)
                {
                    //set the ThisSTaff property
                    StaffList.ThisStaff = AStaff;
                    //add the new record
                    StaffList.Add();
                }
                //otherwise it must be an update
                else
                {
                    //find the record to update
                    StaffList.ThisStaff.Find(StaffNo);
                    //set the thisStaff property
                    StaffList.ThisStaff = AStaff;
                    //update the record
                    StaffList.Update();
                }
                //redirect back to the listpage
                Response.Redirect("StaffsList.aspx");
            }
            else
            {
                //display the error message
                lblError.Text = Error;
            }
        }
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

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffsList.aspx");
    }
}