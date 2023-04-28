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
        //create a new instance of clsSupplier
        clsSupplier Supplier = new clsSupplier();
        //get the data from the session objt
        Supplier = (clsSupplier)Session["Supplier"];
        //display the suppliers info
        Response.Write(Supplier.SupplierID);
        Response.Write(Supplier.SupplierCompanyName);
        Response.Write(Supplier.SupplierPhoneNumber);
        Response.Write(Supplier.SupplierVatNumber);
        Response.Write(Supplier.DateOfRegistration);
        Response.Write(Supplier.SupplierDeliveryDay);
    }
}