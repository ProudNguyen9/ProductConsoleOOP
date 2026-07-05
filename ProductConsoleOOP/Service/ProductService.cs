
public class ProductService : IProductService
{
    private List<Product> products = new List<Product>();
    private ProductValidator validator = new ProductValidator();

    public void Add(Product product)
    {
        List<string> errors = validator.Validate(product);

        if (errors.Count > 0)
        {
            foreach (var error in errors)
            {
                Console.WriteLine(error);
            }
            return;
        }

        product.Id = products.Count == 0 ? 1 : products.Max(p => p.Id) + 1;

        products.Add(product);
        Console.WriteLine("Thêm thành công.");
    }

    public void Delete(int id)
    {
        Product? Productid = products.FirstOrDefault(p => p.Id == id);
        if (Productid != null)
        {
            products.Remove(Productid);
        }
        else
        {
            Console.WriteLine("Không tìm thấy sản phẩm cần xóa ");
        }

    }

    public List<Product> GetAll()
    {
        List<Product> listProduct = new();
        int ProductCount = products.Count;
        if (ProductCount != 0)
        {
            listProduct = products;
            return products;
        }
        else
        {
            Console.WriteLine("Không tìm thấy sản phẩm");
        }
        return listProduct;
    }

    public Product? GetById(int id)
    {
        Product? product = products.FirstOrDefault(p => p.Id == id);

        if (product != null)
        {
            return product;
        }

        return null;
    }

    public void Update(Product product)
    {
        Product? updateProduct = products.FirstOrDefault(p => p.Id == product.Id);

        if (updateProduct == null)
        {
            Console.WriteLine("Không tìm thấy sản phẩm cần cập nhật");
            return;
        }

        updateProduct.Name = product.Name;
        updateProduct.Price = product.Price;
        updateProduct.Quantity = product.Quantity;

        Console.WriteLine("Cập nhật thành công");
    }
    public decimal GetTotalInventoryValue()
    {
        decimal total = 0;

        foreach (Product product in products)
        {
            total += product.TotalValue();
        }

        return total;
    }
    public List<Product> SearchByName(string keyword)
    {
        List<Product> result = new List<Product>();

        foreach (Product product in products)
        {
            if (product.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            {
                result.Add(product);
            }
        }

        return result;
    }
    public List<Product> GetLowStockProducts(int minQuantity)
    {
        List<Product> result = new List<Product>();

        foreach (Product product in products)
        {
            if (product.Quantity < minQuantity)
            {
                result.Add(product);
            }
        }

        return result;
    }
}