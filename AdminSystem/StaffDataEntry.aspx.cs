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
        
        //create a new instance of clsStaff
        clsStaff Staff = new clsStaff();
        //capture the full name
        string FullName = txtFullName.Text;
        //capture the employment date
        string EmploymentDate = txtEmploymentDate.Text;
        //capture the role
        string Role = txtRole.Text;
        //capture the salary
        string Salary = txtSalary.Text;

        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = Staff.Valid( FullName, EmploymentDate, Role, Salary);
        if (Error == "")
        {
            //capture the full name
            Staff.FullName = FullName;
            //capture the employment date
            Staff.EmploymentDate = Convert.ToDateTime(EmploymentDate);
            //capture the role
            Staff.Role = Role;
            //capture the salary
            Staff.Salary = Convert.ToDecimal(Salary);
        
            //Store the details in the session object
            Session["Staff"] = Staff;

            //redirect to the viewer page
            Response.Write("StaffViewer.aspx");

        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
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
            txtRole.Text = Staff.Role;
            txtEmploymentDate.Text = Staff.EmploymentDate.ToString();
            txtSalary.Text = Staff.Salary.ToString();
            ChkActive.Checked = Staff.Active;
        }
    }
}