using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using ClassLibrary;
using System.Web.UI.WebControls;


public partial class _4_ConfirmDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 ProductID;
    //event handler for the load event


    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the ID of the customer to be deleted from the session object
        ProductID = Convert.ToInt32(Session["Product"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStockCollection StockBook = new clsStockCollection();
        //find the record to delete
        StockBook.ThisStock.Find(ProductID);
        //delete the record
        StockBook.Delete();
        //redirect back to the main page
        Response.Redirect("StockList.aspx");

    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }
}
