IProductService productService = new ProductService();

while (true)
{
    Console.WriteLine("===== MENU =====");
    Console.WriteLine("1. Thêm sản phẩm");
    Console.WriteLine("2. Xem danh sách");
    Console.WriteLine("3. Tìm theo Id");
    Console.WriteLine("4. Cập nhật");
    Console.WriteLine("5. Xóa");
    Console.WriteLine("6. Thống kê tổng giá trị kho");
    Console.WriteLine("7. Tìm theo tên");
    Console.WriteLine("8. Xem sản phẩm tồn kho thấp");
    Console.WriteLine("0. Thoát");

    int choice = MenuHelper.ReadInt("Chọn: ");

    switch (choice)
    {
        case 1:
            Console.Write("Nhấn Enter để tiếp tục hoặc nhập 0 để quay lại: ");
            if (Console.ReadLine() == "0")
                break;
            Product product = new Product();

            product.Name = MenuHelper.ReadString("Tên: ");
            product.Price = MenuHelper.ReadDecimal("Giá: ");
            product.Quantity = MenuHelper.ReadInt("Số lượng: ");

            productService.Add(product);
            break;

        case 2:
            Console.Write("Nhấn Enter để tiếp tục hoặc nhập 0 để quay lại: ");
            if (Console.ReadLine() == "0")
                break;
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
            Console.Write("Nhấn Enter để tiếp tục hoặc nhập 0 để quay lại: ");
            if (Console.ReadLine() == "0")
                break;
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
            Console.Write("Nhấn Enter để tiếp tục hoặc nhập 0 để quay lại: ");
            if (Console.ReadLine() == "0")
                break;
            Product updateProduct = new Product();

            updateProduct.Id = MenuHelper.ReadInt("Nhập Id:");
            updateProduct.Name = MenuHelper.ReadString("Tên mới:");
            updateProduct.Price = MenuHelper.ReadDecimal("Giá mới :");
            updateProduct.Quantity = MenuHelper.ReadInt("Số lượng mới : ");

            productService.Update(updateProduct);
            break;

        case 5:
            Console.Write("Nhấn Enter để tiếp tục hoặc nhập 0 để quay lại: ");
            if (Console.ReadLine() == "0")
                break;
            int deleteId = MenuHelper.ReadInt("Nhập Id cần xóa: ");
            productService.Delete(deleteId);
            break;
        case 6:
            decimal total = productService.GetTotalInventoryValue();

            Console.WriteLine($"Tổng giá trị kho: {total:N0} VNĐ");
            break;
        case 7:

            string keyword = MenuHelper.ReadString("Nhập tên cần tìm: ");

            List<Product> result = productService.SearchByName(keyword);

            if (result.Count == 0)
            {
                Console.WriteLine("Không tìm thấy.");
            }
            else
            {
                foreach (Product p in result)
                {
                    Console.WriteLine(p);
                }
            }

            break;
        case 8:

            int min = MenuHelper.ReadInt("Nhập mức tồn kho: ");

            List<Product> lowStock = productService.GetLowStockProducts(min);

            if (lowStock.Count == 0)
            {
                Console.WriteLine("Không có sản phẩm tồn kho thấp.");
            }
            else
            {
                foreach (Product p in lowStock)
                {
                    Console.WriteLine(p);
                }
            }

            break;

        case 0:
            return;

        default:
            Console.WriteLine("Lựa chọn không hợp lệ.");
            break;
    }

    Console.WriteLine();
}