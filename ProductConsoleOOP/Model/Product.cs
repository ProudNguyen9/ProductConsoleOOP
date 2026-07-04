
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

   public void IncreaseStock(int quantity)
{
    if (quantity <= 0)
    {
        Console.WriteLine("Số lượng nhập phải lớn hơn 0.");
        return;
    }

    this.Quantity += quantity;
}

public void DecreaseStock(int quantity)
{
    if (quantity <= 0)
    {
        Console.WriteLine("Số lượng xuất phải lớn hơn 0.");
        return;
    }

    if (this.Quantity == 0)
    {
        Console.WriteLine("Sản phẩm đã hết hàng.");
    }
    else if (quantity > this.Quantity)
    {
        Console.WriteLine($"Sản phẩm không đủ (còn {this.Quantity}).");
    }
    else
    {
        this.Quantity -= quantity;
    }
}
}
