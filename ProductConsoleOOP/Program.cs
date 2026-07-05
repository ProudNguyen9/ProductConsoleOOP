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

    Console.Write("Chọn: ");
    int choice;

    if (!int.TryParse(Console.ReadLine(), out choice))
    {
        Console.WriteLine("Vui lòng nhập số!");
        Console.WriteLine();
        continue;
    }

    switch (choice)
    {
        case 1:
            Product product = new Product();

            Console.Write("Tên: ");
            product.Name = Console.ReadLine();

            decimal price;
            Console.Write("Giá: ");
            while (!decimal.TryParse(Console.ReadLine(), out price))
            {
                Console.Write("Giá không hợp lệ. Nhập lại: ");
            }
            product.Price = price;

            int quantity;
            Console.Write("Số lượng: ");
            while (!int.TryParse(Console.ReadLine(), out quantity))
            {
                Console.Write("Số lượng không hợp lệ. Nhập lại: ");
            }
            product.Quantity = quantity;

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
            int id;
            Console.Write("Nhập Id: ");
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.Write("Id không hợp lệ. Nhập lại: ");
            }

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

            int updateId;
            Console.Write("Nhập Id: ");
            while (!int.TryParse(Console.ReadLine(), out updateId))
            {
                Console.Write("Id không hợp lệ. Nhập lại: ");
            }
            updateProduct.Id = updateId;

            Console.Write("Tên mới: ");
            updateProduct.Name = Console.ReadLine();

            decimal newPrice;
            Console.Write("Giá mới: ");
            while (!decimal.TryParse(Console.ReadLine(), out newPrice))
            {
                Console.Write("Giá không hợp lệ. Nhập lại: ");
            }
            updateProduct.Price = newPrice;

            int newQuantity;
            Console.Write("Số lượng mới: ");
            while (!int.TryParse(Console.ReadLine(), out newQuantity))
            {
                Console.Write("Số lượng không hợp lệ. Nhập lại: ");
            }
            updateProduct.Quantity = newQuantity;

            productService.Update(updateProduct);
            break;

        case 5:
            int deleteId;
            Console.Write("Nhập Id cần xóa: ");
            while (!int.TryParse(Console.ReadLine(), out deleteId))
            {
                Console.Write("Id không hợp lệ. Nhập lại: ");
            }

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