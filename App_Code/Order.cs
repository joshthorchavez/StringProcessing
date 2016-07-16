[System.Serializable]
public class Order
{
    public int CustNum, OrderNum, quant, sku;
    public string invoiceSeq, itemDesc;
    public double price, weight;

    public Order(int CustNum, int OrderNum, string invoiceSeq, int sku, string itemDesc, int quant, double price, double weight)
    {
        this.CustNum = CustNum;
        this.sku = sku;
        this.OrderNum = OrderNum;
        this.invoiceSeq = invoiceSeq;
        this.itemDesc = itemDesc;
        this.price = price;
        this.quant = quant;
        this.weight = weight;
    }
    public double getShipping()
    {
        return weight * 1.2;
    }
}