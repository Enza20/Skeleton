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
        //create a new instance of clsSupplier
        clsSupplier Supplier = new clsSupplier();
        string SupplierID = TextBox1.Text;
        string SupplierCompanyName = TextBox2.Text;
        string SupplierPhoneNumber = TextBox3.Text;
        string SupplierVatNumber = TextBox4.Text;
        string DateOfRegistration = TextBox5.Text;
        string SupplierDeliveryDay = TextBox6.Text;
        string Error = "";
        Error = Supplier.Valid(SupplierCompanyName, SupplierPhoneNumber, SupplierVatNumber, DateOfRegistration, SupplierDeliveryDay);
        if (Error == "")
        {
            //capture info
            Supplier.SupplierID = int.Parse(TextBox1.Text);
            Supplier.SupplierCompanyName = TextBox2.Text;
            Supplier.SupplierPhoneNumber = TextBox3.Text;
            Supplier.SupplierVatNumber = TextBox4.Text;
            Supplier.DateOfRegistration = DateTime.Parse(TextBox5.Text);
            Supplier.SupplierDeliveryDay = TextBox6.Text;

            //Store the supplier in the session object
            Session["Supplier"] = Supplier;

            //navigate to the viewer page
            Response.Redirect("SuppliersViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        clsSupplier Supplier = new clsSupplier();
        Int32 SupplierID;
        Boolean Found = false;
        SupplierID = Convert.ToInt32(TextBox1.Text);
        Found = Supplier.Find(SupplierID);
        if (Found == true)
        {
            //display the values of the properties in the form
            TextBox2.Text = Supplier.SupplierCompanyName;
            TextBox3.Text = Supplier.SupplierPhoneNumber;
            TextBox4.Text = Supplier.SupplierVatNumber;
            TextBox5.Text = Supplier.DateOfRegistration.ToString();
            TextBox6.Text = Supplier.SupplierDeliveryDay;
            chkSupplierActive.Checked = Supplier.SupplierActive;


        }

    }

    protected void chkSupplierActive_CheckedChanged(object sender, EventArgs e)
    {

    }
}