[System.Serializable]
public class newOrder
{
    public int custNum, orderNum, zip, ordQty;
    public string custName, street, city, state, SKU, description, ordDate;
    public double cost, price, weight;

    public newOrder(int orderNum, int custNum, string custName, string street, string city, string state, int zip, string SKU, string description, double cost, double price, double weight, string ordDate, int ordQty)
    {
        this.custNum = custNum;
        this.SKU = SKU;
        this.orderNum = orderNum;
        this.custName = custName;
        this.street = street;
        this.city = city;
        this.state = state;
        this.zip = zip;
        this.description = description;
        this.cost = cost;
        this.price = price;
        this.weight = weight;
        this.ordDate = ordDate;
        this.ordQty = ordQty;
    }
    public double getExtendedPrice()
    {
        return price * ordQty;
    }
    public double getExtendedWeight()
    {
        return weight * ordQty;
    }
}