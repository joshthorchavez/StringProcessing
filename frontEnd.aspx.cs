using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class frontEnd : System.Web.UI.Page
{
    private List<Items> theItems;
    public Items curItem;

    protected void Page_Load(object sender, EventArgs e)
    {
        OleDbConnection cn;
        OleDbCommand cmd;
        OleDbDataReader dr;

        this.theItems = new List<Items>();
        
        if (IsPostBack == false)
        {
            try
            {
                

                
                
                //  Get database objects...
                //  Connect to database and open...
                cn = new OleDbConnection();

                if (Request.UserHostAddress.ToString().Equals("::1"))
                {
                    // Local server...
                    cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Users\Thor\Desktop\StoreDatabase.accdb;Persist Security Info=False;";
                }
                else
                {
                    // Remote server...  (Note difference for older version of Access.)
                    cn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=h:\root\home\joshthor-001\www\site1\StoreDatabase2.mdb";
                }

                // Create the SQL command...
                cmd = new OleDbCommand("SELECT * FROM Items", cn);

                cn.Open();

                // Execute the SQL statement and get the dataset...
                dr = cmd.ExecuteReader();

                //  This code
                //this.ListBox1.DataSource = dr;
                //this.ListBox1.DataTextField = "ItemDesc";
                //this.ListBox1.DataBind();


                // Iterate over the dataset, create orders and add to collection...

                while (dr.Read())
                {
                    Items item = new Items(dr["ItemName"].ToString(), dr["Description"].ToString(), int.Parse(dr["Price"].ToString()), double.Parse(dr["weight"].ToString()), dr["URL"].ToString());
                  
                    theItems.Add(item);
                }

                dr.Close();
                cn.Close();
            }
            catch (Exception err)
            {
                Label1.Text = "THIS? " + err.Message;
                return;
            }

            String choice = Request.QueryString["Item"];
            foreach(Items item in theItems)
            {
                if(choice.CompareTo("mirror") == 0)
                {
                    if (item.itemName == "Old Fashioned Mirror")
                    {
                        curItem = item;
                        Image1.ImageUrl = item.url.ToString();
                        name.Text = "<b>" + item.itemName.ToString() + "</b>";
                        description.Text = item.description.ToString();
                        price.Text = "$" + (0.00M + item.price).ToString();
                    }
                }
                if(choice.CompareTo("book") == 0)
                {
                    if (item.itemName == "Antique Picture Book")
                    {
                        this.curItem = item;
                        Image1.ImageUrl = item.url.ToString();
                        name.Text = "<b>" + item.itemName.ToString() + "</b>";
                        description.Text = item.description.ToString();
                        price.Text = "$" + (0.00M + item.price).ToString();
                    }
                }
                if(choice.CompareTo("video") == 0)
                {
                    if(item.itemName == "Childs movie")
                    {
                        this.curItem = item;
                        Image1.ImageUrl = item.url.ToString();
                        name.Text = "<b>" + item.itemName.ToString() + "</b>";
                        description.Text = item.description.ToString();
                        price.Text = "$" + (0.00M + item.price).ToString();
                    }
                }
                if(choice.CompareTo("movies") == 0)
                {
                    if(item.itemName == "Home Movies")
                    {
                        this.curItem = item;
                        Image1.ImageUrl = item.url.ToString();
                        name.Text = "<b>" + item.itemName.ToString() + "</b>";
                        description.Text = item.description.ToString();
                        price.Text = "$" + (0.00M + item.price).ToString();
                    }
                }
                if(choice.CompareTo("doll") == 0)
                {
                    if(item.itemName == "Nice Doll")
                    {
                        this.curItem = item;
                        Image1.ImageUrl = item.url.ToString();
                        name.Text = "<b>" + item.itemName.ToString() + "</b>";
                        description.Text = item.description.ToString();
                        price.Text = "$" + (0.00M + item.price).ToString();
                    }
                }
            }
            Session["curitem"] = curItem;


        }  //  End !IsPostBack
    }

    private TableCell addCell(String pText)
    {
        TableCell cell = new TableCell();
        cell.BorderStyle = BorderStyle.Solid;
        cell.BorderWidth = 0;
        
        cell.Width = new Unit("15%");
        cell.Text = pText;

        return cell;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Items cur = (Items)Session["curitem"];
        cur.added();
        if (Session["items"] == null)
        {

            List<Items> inCart = new List<Items>();
            inCart.Add(cur);
            Session["items"] = inCart;
        }
        else
        {
            Boolean add = true;
            List<Items> inCart = (List<Items>)Session["items"];
            foreach(Items item in inCart)
            {
                if(item != null)
                {
                    if (item.itemName.ToString().CompareTo(cur.itemName.ToString()) == 0)
                    {
                        item.added();
                        add = false;
                        break;

                    }
                }
            }
            if(add == true)
            {
                inCart.Add(cur);
            }
            Session["items"] = inCart;
        }
        Response.Redirect("cart.aspx");
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