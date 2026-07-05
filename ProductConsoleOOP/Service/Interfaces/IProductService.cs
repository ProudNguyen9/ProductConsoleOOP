public interface IProductService
{
    void Add(Product product);
    List<Product> GetAll();
    Product? GetById(int id);
    void Update(Product product);
    void Delete(int id);

}