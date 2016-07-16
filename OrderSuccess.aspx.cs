using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderSuccess : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label2.Text = "Order " + Request.QueryString["orderID"] + " has been processed";
    }

    protected void items_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShoppingPage.aspx");
    }
    protected void cart_Click(object sender, EventArgs e)
    {
        Response.Redirect("cart.aspx");
    }
}