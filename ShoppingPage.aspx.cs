using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShoppingPage : System.Web.UI.Page
{
    

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void items_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShoppingPage.aspx");
    }
    protected void cart_Click(object sender, EventArgs e)
    {
        Response.Redirect("cart.aspx");
    }
    protected void ImageButton1_Click(object sender, EventArgs e)
    {
        string url = "frontEnd.aspx?";
        url += "Item=mirror";
        Response.Redirect(url);
    }
    protected void ImageButton2_Click(object sender, EventArgs e)
    {
        string url = "frontEnd.aspx?";
        url += "Item=book";
        Response.Redirect(url);
    }
    protected void ImageButton3_Click(object sender, EventArgs e)
    {
        string url = "frontEnd.aspx?";
        url += "Item=video";
        Response.Redirect(url);
    }
    protected void ImageButton4_Click(object sender, EventArgs e)
    {
        string url = "frontEnd.aspx?";
        url += "Item=movies";
        Response.Redirect(url);
    }
    protected void ImageButton5_Click(object sender, EventArgs e)
    {
        string url = "frontEnd.aspx?";
        url += "Item=doll";
        Response.Redirect(url);
    }
}