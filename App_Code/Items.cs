using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[Serializable]
public class Items
{
    public string itemName, description, url;
    public int price;
    public double weight;
    public Boolean inCart;
    public int quant;

    public Items(string itemName, string description, int price, double weight, string url) 
    {
        this.itemName = itemName;
        this.description = description;
        this.price = price;
        this.url = url;
        this.weight = weight;
        inCart = false;
        quant = 0;
        //
        // TODO: Add constructor logic here
        //
    }
    public void added()
    {
        inCart = true;
        quant++;
    }
    public void removed()
    {
        quant--;
        if(quant < 1)
        {
            inCart = false;
        }
    }
    public double totPrice()
    {
        return quant * price;
    }
    public double totWeight()
    {
        return quant * weight;
    }
}