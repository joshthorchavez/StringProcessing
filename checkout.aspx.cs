using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class checkout : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            var items = (List<Items>)Session["items"];

            int itemNum = 0; int itemQuant = 0; double itemWeight = 0; double price = 0;
            foreach (Items item in items)
            {
                itemNum++;
                itemQuant += item.quant;
                itemWeight += item.totWeight();
                price += item.totPrice();
            }

            double shippingPrice = itemWeight * .46;
            double totPrice = price + shippingPrice;

            numlabel.Text = itemNum.ToString();
            quantlabel.Text = itemQuant.ToString();
            weightlabel.Text = itemWeight.ToString();
            itemlabel.Text = "$" + ((0.00M + decimal.Parse(price.ToString())).ToString("0.00")); itemlabel2.Text = "$" + ((0.00M + decimal.Parse(price.ToString())).ToString("0.00"));
            totallabel.Text = "$" + ((0.00M + decimal.Parse(totPrice.ToString())).ToString("0.00"));
            shiplabel.Text = "$" + ((0.00M + decimal.Parse(shippingPrice.ToString())).ToString("0.00"));

            if(Session["orderNum"] != null)
            {
                var orderNum = int.Parse(Session["orderNum"].ToString());
                orderNum++;
                ordlabel.Text = "Order-" + orderNum.ToString();
            }
            else
            {
                int orderNum = 1;
                ordlabel.Text = "Order-" + orderNum.ToString();
            }
        }
        catch
        {
            //do nothing - it shouldnt get here
        }
    }
    protected void items_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShoppingPage.aspx");
    }
    protected void cart_Click(object sender, EventArgs e)
    {
        Response.Redirect("cart.aspx");
    }
    protected void submit_Click(object sender, EventArgs e)
    {
        double total = 0.0;

        string sWork = "CSCD379 - ASP.Net Programming with C# \n\n";
        sWork += "Your order has been processed.\n\n";
        sWork += "Order number: " + ordlabel.Text + "\n";

        
        foreach (Items item in (List<Items>)Session["items"])
        {
            total = item.totPrice();
            sWork += item.itemName;
            for (int i = item.itemName.Length; i < 30; i++)
            {
                sWork += " ";
            }
            sWork += "\t" + item.quant + "\t" + "$" + ((0.00M + decimal.Parse(item.price.ToString())).ToString("0.00")) + "\t" + "$" + ((0.00M + decimal.Parse(item.totPrice().ToString())).ToString("0.00")) + "\n";
        }
       
        sWork += "\n\nTotal quantity: " + this.quantlabel.Text;
        sWork += "\nShipping cost: " + this.shiplabel.Text;
        sWork += "\nTotal order cost: " + this.totallabel.Text;

        sWork += "\n\n" + this.namebox.Text;
        sWork += "\n" + this.streetbox.Text;
        sWork += "\n" + this.citybox.Text;
        sWork += " " + this.statebox.Text;
        sWork += ", " + this.zipbox.Text;

        sWork += "\n\nIf you did not place an order with Big Bobs Magical Storefront, please contact mailto:garbage@theDumpster.com";
        

        //start here 
        MailMessage m = new MailMessage();
        SmtpClient sc = new SmtpClient();
        m.From = new MailAddress("store@joshdchavez.com");
        m.To.Add(emailbox.Text);
        m.Subject = "Order number " + ordlabel.Text + " has been processed";
        m.Body = sWork;
        sc.Host = "mail.joshdchavez.com";
        string str1 = "gmail.com";
        string str2 = "store@joshdchavez.com".ToLower();
        if (str2.Contains(str1))
        {
            try
            {
                sc.Port = 587;
                sc.Credentials = new System.Net.NetworkCredential("store@joshdchavez.com", "P@ssword");
                sc.EnableSsl = true;
                sc.Send(m);
                Response.Write("Email Send successfully");
            }
            catch (Exception ex)
            {
                Response.Write("<BR><BR>* Please double check the From Address and Password to confirm that both of them are correct. <br>");
                Response.Write("<BR><BR>If you are using gmail smtp to send email for the first time, please refer to this KB to setup your gmail account: http://www.smarterasp.net/support/kb/a1546/send-email-from-gmail-with-smtp-authentication-but-got-5_5_1-authentication-required-error.aspx?KBSearchID=137388");
                Response.End();
            }
        }
        else
        {
            try
            {
                sc.Port = 25;
                sc.Credentials = new System.Net.NetworkCredential("store@joshdchavez.com", "P@ssword");
                sc.EnableSsl = false;
                sc.Send(m);
                Response.Write("Email Send successfully");
            }
            catch (Exception ex)
            {
                Response.Write("<BR><BR>* Please double check the From Address and Password to confirm that both of them are correct. <br>");
                Response.End();
            }
        }

        sc = null;
        Session.Clear();
        Response.Redirect("OrderSuccess.aspx?" + "orderID=" + this.ordlabel.Text);
        //donothing
    }
}