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
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of customers to be processed
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (CustomerId != -1)
            {
                //display the current data for the record
                DisplayCustomers();
            }
        }

    }

    //button OK
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture the full name
        string CustomerFullName = txtCustomerFullName.Text;
        //capture the phone number
        string CustomerPhoneNumber = txtCustomerPhoneNumber.Text;
        //capture the billing address
        string CustomerBillingAddress = txtCustomerBillingAddress.Text;
        //capture the date of registration
        string DateOfRegistration = txtDateOfRegistration.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = ACustomer.Valid(CustomerFullName, CustomerPhoneNumber, CustomerBillingAddress, DateOfRegistration);
        if (Error == "")
        {
            //capture the customer id (PK)
            ACustomer.CustomerId = CustomerId;
            //capture the full name
            ACustomer.CustomerFullName = txtCustomerFullName.Text;
            //capture the phone number
            ACustomer.CustomerPhoneNumber = txtCustomerPhoneNumber.Text;
            //capture the billing address
            ACustomer.CustomerBillingAddress = txtCustomerBillingAddress.Text;
            //capture the date of registration
            ACustomer.DateOfRegistration = Convert.ToDateTime(txtDateOfRegistration.Text);
            //capture isAllowed
            ACustomer.IsAllowed = chkIsAllowed.Checked;

            /*   // Old: store the customer in the session object
               Session["ACustomer"] = ACustomer;
               //Navigate to the viewer page
               Response.Redirect("CustomerViewer.aspx");
            */

            //create a new instance of the customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            //if this is a new record i.e. CustomerId = -1 then add the data
            if (CustomerId == -1)
            {
                //set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //add the new record
                CustomerList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(CustomerId);
                //set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //update the record
                CustomerList.Update();
            }
            
            //redirect back to the listpage
            Response.Redirect("CustomerLook.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
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

    void DisplayCustomers()
    {
        //create an instance of the customer book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to update
        CustomerBook.ThisCustomer.Find(CustomerId);
        //display the data for this record
        txtCustomerId.Text = CustomerBook.ThisCustomer.CustomerId.ToString();
        txtCustomerFullName.Text = CustomerBook.ThisCustomer.CustomerFullName;
        txtCustomerPhoneNumber.Text = CustomerBook.ThisCustomer.CustomerPhoneNumber;
        txtCustomerBillingAddress.Text = CustomerBook.ThisCustomer.CustomerBillingAddress;
        txtDateOfRegistration.Text = CustomerBook.ThisCustomer.DateOfRegistration.ToString();
        chkIsAllowed.Checked = CustomerBook.ThisCustomer.IsAllowed;
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}