using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff Staff = new clsStaff();
        //get the data from the session object
        Staff = (clsStaff)Session["Staff"];
        //display the full name for this entry
        Response.Write(Staff.FullName);
        Response.Write(Staff.Role);
        
        Response.Write(Staff.EmploymentDate);
        Response.Write(Staff.Salary);
        Response.Write(Staff.StaffId);


    }
}