
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public Product()
    {

    }
    public Product(int Id, string name, decimal Price, int Quantity)
    {
        this.Id = Id;
        this.Name = name;
        this.Price = Price;
        this.Quantity = Quantity;
    }
    public decimal TotalValue()
    {
        decimal totalValue = this.Price * this.Quantity;
        return totalValue;

    }
}
