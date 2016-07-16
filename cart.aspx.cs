using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cart : System.Web.UI.Page
{
    private Table tbl;
    private List<TextBox> tb;

    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["items"] != null)
        {
            tb = new List<TextBox>();
            var theItems = (List<Items>)Session["items"];
            if (theItems != null)
            {
                try
                {

                    //  Restore the orders array from the viewstate...

                    double count, ext, weight; count = 0; ext = 0; weight = 0;
                    TableRow row;
                    row = new TableRow();
                    row.BorderStyle = BorderStyle.Solid;
                    row.Cells.Add(addCell("Order Summary"));
                    row.Cells.Add(addCell("Unit Price"));
                    row.Cells.Add(addCell("Quantity"));
                    row.Cells.Add(addCell("Extension"));
                    row.Cells.Add(addCell("Weight"));
                    Table1.Rows.Add(row);
                    
                    foreach (Items item in theItems)
                    {
                        if(item != null && item.inCart)
                        {
                            row = new TableRow();
                            row.BorderStyle = BorderStyle.Solid;
                            row.Cells.Add(addCell(item.itemName.ToString()));
                            row.Cells.Add(addCell("$" + (0.00M + item.price).ToString()));
                            TextBox txtbx = new TextBox();
                            txtbx.Text = item.quant.ToString();
                            txtbx.Attributes["item"] = item.itemName;
                            TableCell bxCell = new TableCell();
                            bxCell.Controls.Add(txtbx);
                            tb.Add(txtbx);
                            row.Cells.Add(bxCell);
                            //row.Cells.Add(addCell(item.quant.ToString()));
                            row.Cells.Add(addCell("$" + (0.00M + decimal.Parse(item.totPrice().ToString())).ToString()));

                            row.Cells.Add(addCell(item.totWeight().ToString()));
                            count = count + item.quant;
                            weight = weight + item.totWeight();
                            ext = ext + item.totPrice();


                            Button btn = new Button();
                            btn.Text = "Remove";
                            btn.Click += new EventHandler(btn_Click);
                            btn.Attributes["item"] = item.itemName;
                            TableCell btnCell = new TableCell();
                            btnCell.Controls.Add(btn);
                            row.Cells.Add(btnCell);

                            Button upbtn = new Button();
                            upbtn.Text = "Update Quantity";
                            upbtn.Click += new EventHandler(upbtn_Click);
                            upbtn.Attributes["item"] = item.itemName;
                            TableCell upbtnCell = new TableCell();
                            upbtnCell.Controls.Add(upbtn);
                            row.Cells.Add(upbtnCell);

                            Table1.Rows.Add(row);
                        }

                    }

                    row = new TableRow();
                    row.Cells.Add(addEndCell(""));
                    row.Cells.Add(addEndCell(""));
                    row.Cells.Add(addEndCell("Count: " + count.ToString()));
                    row.Cells.Add(addEndCell("$" + (0.00M + decimal.Parse(ext.ToString())).ToString()));
                    row.Cells.Add(addEndCell(weight.ToString()));
                    Table1.Rows.Add(row);
                    
                }

                catch (Exception err)
                {
                    Label1.Text = err.Message;
                }
            }
        }  //  End !IsPostBack
        else
        {
        }

    }

    private TableCell addCell(String pText)
    {
        TableCell cell = new TableCell();
        cell.BorderStyle = BorderStyle.Solid;
        cell.BorderWidth = 1;
        cell.Text = pText;
        return cell;
    }
    private TableCell addEndCell(String pText)
    {
        TableCell cell = new TableCell();
        cell.BorderStyle = BorderStyle.None;
        cell.BorderWidth = 1;
        cell.Text = pText;
        return cell;
    }
    protected void items_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShoppingPage.aspx");
    }
    protected void cart_Click(object sender, EventArgs e)
    {
        Response.Redirect("cart.aspx");
    }
    protected void btn_Click(object sender, EventArgs e)
    {
        String item = ((Button)sender).Attributes["item"];
        var items = (List<Items>)Session["items"];
        foreach(Items a in items)
        {
            if(a.itemName.CompareTo(item) == 0)
            {
                items.Remove(a);
                break;
            }
        }
        Session["items"] = items;
        Response.Redirect(Request.RawUrl);

    }
    protected void checkOut_Click(object sender, EventArgs e)
    {
        if (Session["items"] != null)
        {
            Response.Redirect("checkout.aspx");
        }
    }
    protected void upbtn_Click(object sender, EventArgs e)
    {
        String item = ((Button)sender).Attributes["item"];
        var items = (List<Items>)Session["items"];
        foreach(TextBox b in tb)
        {
            if (b.Attributes["item"].CompareTo(item) == 0)
            {
                foreach (Items a in items)
                {
                    if (a.itemName.CompareTo(item) == 0)
                    {
                        Items cur = a;
                        items.Remove(a);
                        try
                        {
                            int i = int.Parse(b.Text);
                            if(i >= 0)
                            {
                                cur.quant = i;
                            }
                        }
                        catch
                        {

                        }
                        
                        items.Add(cur);
                        break;
                    }
                }
            }
        }
        Session["items"] = items;
        Response.Redirect(Request.RawUrl);

    }
}