using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStock Stock = new clsStock();
        Stock = (clsStock)Session["Stock"];
        Response.Write(Stock.ProductID);
        Response.Write(Stock.Description);
        Response.Write(Stock.Quantity);
        Response.Write(Stock.SupplierID);
        Response.Write(Stock.ExpiryDate);
        Response.Write(Stock.ProductPrice);
    }
}