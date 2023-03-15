using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        /*  we are creating an instance of the class Staff and storing some
         *  of the data in the object for display on a second page.
         */

        //create a new instance of clsStaff

        clsStaff Staff = new clsStaff();
       Staff.StaffId = int.Parse(txtStaffId.Text);
        //capture the full name
        Staff.FullName = TextBox1.Text;
        // Staff.Role = lblRole.Text;
        Staff.Date = DateTime.Parse(TextBox4.Text);
        Staff.Salary =decimal.Parse(TextBox5.Text);
        //Store the full name in the session object
        Session["Staff"] = Staff;


        //navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");
    }

    protected void txtStaffId_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {


        clsStaff Staff = new clsStaff();
        Int32 StaffId;
        Boolean Found = false;
        StaffId = Convert.ToInt32(txtStaffId.Text);
        //find the record
        Found = Staff.Find(StaffId);
        //if found
        if(Found == true)
        {
            //display the values of the properties
            txtStaffId.Text = Staff.StaffId.ToString();
            txtFullName.Text = Staff.FullName;


        }
    }
}