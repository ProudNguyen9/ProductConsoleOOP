public interface IProductService
{
    void Add(Product product);
    List<Product> GetAll();
    Product? GetById(int id);
    void Update(Product product);
    void Delete(int id);
    decimal GetTotalInventoryValue();
    List<Product> SearchByName(string keyword);
    List<Product> GetLowStockProducts(int minQuantity);
}