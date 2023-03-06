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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStock Stock = new clsStock();

        Stock.ProductID = int.Parse(txtStockID.Text);
        Stock.Description = txtDescription.Text;
        Stock.Quantity = int.Parse(txtQuantity.Text);
        Stock.ExpiryDate = DateTime.Parse(txtExpiryDate.Text);
        Stock.SupplierID = int.Parse(txtSupplierID.Text);
        Stock.ProductPrice = double.Parse(txtProductPrice.Text);
        Session["Stock"] = Stock;
        Response.Redirect("StockViewer.aspx");
    }
}