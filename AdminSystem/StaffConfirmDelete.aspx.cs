using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 StaffId;
    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the staff id to be deleted from the session object
        StaffId = Convert.ToInt32(Session["StaffId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteStaff();
        
        //redirect back to the main page
        Response.Redirect("StaffList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }

    void DeleteStaff()
    {
        //function to delete the selected record
        //create a new instance 
        clsStaffCollection StaffID = new clsStaffCollection();
        //find the record to delete
        StaffID.ThisStaff.Find(StaffId);
        //delete the record
        StaffID.Delete();
    }
}