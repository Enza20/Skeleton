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


    protected void Button1_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
       //capture the full name
        ACustomer.CustomerFullName = txtCustomerFullName.Text;


        //capture the phone number
        ACustomer.CustomerPhoneNumber = txtCustomerPhoneNumber.Text;

        //capture the phone number
        ACustomer.CustomerBillingAddress = txtCustomerBillingAddress.Text;

        //capture the date of registration
      //  ACustomer.DateOfRegistration = txtDateOfRegistration;

        //capture the phone number
    //    ACustomer.CustomerId = txtCustomerId.Text;


        //store the customer in the session object
        Session["ACustomer"] = ACustomer;

        //Navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }


}