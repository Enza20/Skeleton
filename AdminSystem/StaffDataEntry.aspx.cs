using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 StaffId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the staff id to be processed
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if (IsPostBack == false)
        {   //if this is not the new record
            if(StaffId != -1)
            {
                //display the current data for the record
                DisplayStaff();
            }
        }

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
            /* int StaffId = -1;
             if (ViewState["StaffId"] != null)
             {
                 StaffId = Convert.ToInt32(ViewState["StaffId"]);
             }  */
             //capture the staff id
             Staff.StaffId = StaffId;
            //capture the full name
            Staff.FullName = txtFullName.Text;
             //capture the employment date
             Staff.EmploymentDate = Convert.ToDateTime(txtEmploymentDate.Text);
             //capture the role
             Staff.Role = txtRole.Text;
             //capture the salary
             Staff.Salary = Convert.ToDecimal(txtSalary.Text);
             //capture active
             Staff.Active = ChkActive.Checked;
             //create an instance of the staff collection
             clsStaffCollection StaffList = new clsStaffCollection();

             //if this is a new record, then add the data
             if (StaffId == -1)
             {
                 //set ThisStaff property
                 StaffList.ThisStaff = Staff;
                 //add the new record
                 StaffList.Add();
             }
             //otherwise it must be an update
             else
             {
                 //find the record to update
                 StaffList.ThisStaff.Find(StaffId);
                 //set ThisStaff property
                 StaffList.ThisStaff = Staff;
                 //update the record
                 StaffList.Update();
                //redirect back to the list page
              //  Response.Redirect("StaffList.aspx");
            }


             

             //Store the details in the session object
            // Session["Staff"] = Staff;

             //redirect to the viewer page
            // Response.Write("StaffViewer.aspx");

         }
         else
         {
             //display the error message
             lblError.Text = Error;
         }
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
       

    void DisplayStaff()
    {
        //create an instance of the staff id
        clsStaffCollection StaffID = new clsStaffCollection();
        //find the record to update
        StaffID.ThisStaff.Find(StaffId);
        //display the data for this record
        txtStaffId.Text = StaffID.ThisStaff.StaffId.ToString();
        txtFullName.Text = StaffID.ThisStaff.FullName;
        txtRole.Text = StaffID.ThisStaff.Role;
        txtSalary.Text = StaffID.ThisStaff.Salary.ToString();
        txtEmploymentDate.Text = StaffID.ThisStaff.EmploymentDate.ToString();
        ChkActive.Checked = StaffID.ThisStaff.Active;
    }

 

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main page
        Response.Redirect("StaffList.aspx");
    }






    protected void btnList1_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }


}
