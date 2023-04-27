﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }
    }

    void DisplayCustomers()
    {
        clsCustomerCollection Customers1 = new clsCustomerCollection();
        //set the data source to list of customers in the collection
        lstCustomerList.DataSource = Customers1.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerId";
        //set the data field to display
        lstCustomerList.DataTextField = "CustomerFullName";
        //bind the data to the list
        lstCustomerList.DataBind();

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CustomerId"] = -1;
        //redirect to the data entry page
        Response.Redirect("CustomerDataEntry.aspx");

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 CustomerId;
        //if a record has been slected from the list
        if (lstCustomerList.SelectedIndex != -1) //allows us to make sure that the entry on the list has been clicked
        {
            //get the primary key value of the record to edit
            CustomerId = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerId"] = CustomerId;
            //redirect to the edit page
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.InnerText = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 CustomerId;
        //if a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //GET THE pk VALUE OF THE RECORD TO DELETE
            CustomerId = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerId"] = CustomerId;
            //redirect to the delete page
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.InnerText = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByBillingAddress(txtFilter.Text);
        lstCustomerList.DataSource = Customers.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerId";
        //set the name of the field to display
        lstCustomerList.DataTextField = "CustomerBillingAddress";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByBillingAddress("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        lstCustomerList.DataSource = Customers.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerId";
        //set the name of the field to display
        lstCustomerList.DataTextField = "PostCode";
        //bind the data to the list
        //lstCustomerList.DataBind();
        Response.Redirect("CustomerList.aspx");

    }
}