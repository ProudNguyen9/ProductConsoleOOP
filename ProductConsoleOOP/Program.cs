IProductService productService = new ProductService();

while (true)
{
    Console.WriteLine("===== MENU =====");
    Console.WriteLine("1. Thêm sản phẩm");
    Console.WriteLine("2. Xem danh sách");
    Console.WriteLine("3. Tìm theo Id");
    Console.WriteLine("4. Cập nhật");
    Console.WriteLine("5. Xóa");
    Console.WriteLine("0. Thoát");

    int choice = MenuHelper.ReadInt("Chọn: ");

    switch (choice)
    {
        case 1:
            Product product = new Product();

            product.Name = MenuHelper.ReadString("Tên: ");
            product.Price = MenuHelper.ReadDecimal("Giá: ");
            product.Quantity = MenuHelper.ReadInt("Số lượng: ");

            productService.Add(product);
            break;

        case 2:
            List<Product> products = productService.GetAll();

            if (products.Count == 0)
            {
                Console.WriteLine("Danh sách trống");
            }
            else
            {
                foreach (Product p in products)
                {
                    Console.WriteLine(p);
                }
            }
            break;

        case 3:
            int id = MenuHelper.ReadInt("Nhập Id: ");

            Product? productById = productService.GetById(id);

            if (productById == null)
            {
                Console.WriteLine("Không tìm thấy sản phẩm");
            }
            else
            {
                Console.WriteLine(productById);
            }
            break;

        case 4:
            Product updateProduct = new Product();

            updateProduct.Id= MenuHelper.ReadInt("Nhập Id:");
            updateProduct.Name = MenuHelper.ReadString("Tên mới:");
            updateProduct.Price = MenuHelper.ReadDecimal("Giá mới :");
            updateProduct.Quantity = MenuHelper.ReadInt("Số lượng mới : ");

            productService.Update(updateProduct);
            break;

        case 5:
            int deleteId = MenuHelper.ReadInt("Nhập Id cần xóa: ");
            productService.Delete(deleteId);
            break;

        case 0:
            return;

        default:
            Console.WriteLine("Lựa chọn không hợp lệ.");
            break;
    }

    Console.WriteLine();
}