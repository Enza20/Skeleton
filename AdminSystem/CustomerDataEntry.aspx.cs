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



    protected void Button1_Click1(object sender, EventArgs e)
    {
        //create an instance of the class we want to create
        clsCustomer ACustomer = new clsCustomer();
        //variable to store primary key
        Int32 CustomerId;
        // variable to store the result of the find operation
        Boolean Found = false;
        //get the PK entered by the user
        CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //Find the record
        Found = ACustomer.Find(CustomerId);
        //if found
        if ( Found == true)
        {
            //display the values of the properties in the form
            txtCustomerFullName.Text = ACustomer.CustomerFullName;
            txtCustomerPhoneNumber.Text = ACustomer.CustomerPhoneNumber;
            txtCustomerBillingAddress.Text = ACustomer.CustomerBillingAddress;
            txtDateOfRegistration.Text = ACustomer.DateOfRegistration.ToString();
            chkIsAllowed.Checked = ACustomer.IsAllowed;


        }
    }
}