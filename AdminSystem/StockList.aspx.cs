using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _4_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStock();
        }
    }

    void DisplayStock()
    {
        clsStockCollection Stock1 = new clsStockCollection();
        //set the data source to list of customers in the collection
        lstStockList.DataSource = Stock1.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "ProductID";
        //set the data field to display
        lstStockList.DataTextField = "Description";
        //bind the data to the list
        lstStockList.DataBind();

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["ProductID"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 ProductID;
        //if a record has been slected from the list
        if (lstStockList.SelectedIndex != -1) //allows us to make sure that the entry on the list has been clicked
        {
            //get the primary key value of the record to edit
            ProductID = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["ProductID"] = ProductID;
            //redirect to the edit page
            Response.Redirect("StockDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.InnerText = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 ProductID;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //GET THE pk VALUE OF THE RECORD TO DELETE
            ProductID = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["ProductID"] = ProductID;
            //redirect to the delete page
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.InnerText = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ReportByDescription(txtFilter.Text);
        lstStockList.DataSource = Stock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "ProductID";
        //set the name of the field to display
        lstStockList.DataTextField = "Description";
        //bind the data to the list
        lstStockList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ReportByDescription("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        lstStockList.DataSource = Stock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "ProductID";
        //set the name of the field to display
        lstStockList.DataTextField = "Description";
        //bind the data to the list
        //lstCustomerList.DataBind();
        Response.Redirect("StockList.aspx");

    }
}