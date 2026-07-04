Console.WriteLine("Tạo và in 5 sản phẩm ra màn hình ");
Product product1 = new Product(1, "táo", 10000, 9);
Product product2 = new Product(2, "ổi", 10000, 7);
Product product3 = new Product(3, "mít", 10000, 8);
Product product4 = new Product(4, "dưa", 10000, 6);
Product product5 = new Product(5, "chuối", 10000, 9);

Console.WriteLine($"Sản phẩn thứ {product1.Id} | Tên : {product1.Name} | Giá : {product1.Price} | Số Lượng : {product1.Quantity}");
Console.WriteLine($"Sản phẩn thứ {product2.Id} | Tên : {product2.Name} | Giá : {product2.Price} | Số Lượng : {product2.Quantity}");
Console.WriteLine($"Sản phẩn thứ {product3.Id} | Tên : {product3.Name} | Giá : {product3.Price} | Số Lượng : {product3.Quantity}");
Console.WriteLine($"Sản phẩn thứ {product4.Id} | Tên : {product4.Name} | Giá : {product4.Price} | Số Lượng : {product4.Quantity}");
Console.WriteLine($"Sản phẩn thứ {product5.Id} | Tên : {product5.Name} | Giá : {product5.Price} | Số Lượng : {product5.Quantity}");
Console.WriteLine($"Tổng tiền của sản phẩm 1 :{product1.TotalValue()}");

Console.WriteLine("Tạo một học sinh để tính tuổi ");
Student student = new Student(1, "Nguyễn Hữu Hào", new DateOnly(2004, 4, 21));
Console.WriteLine($"Học sinh {student.Id} | Tên : {student.Name} | tuổi : {student.CalculateAge()} ");

Console.WriteLine();
Console.WriteLine("Test validatetor class product");

ProductValidator validator = new ProductValidator();

Product product6 = new Product(6, "Cam", 15000, 10);

List<string> errors = validator.Validate(product6);

if (errors.Count == 0)
{
    Console.WriteLine("Product 6 hợp lệ.");
}
else
{
    Console.WriteLine("Product 6 không hợp lệ:");

    foreach (string error in errors)
    {
        Console.WriteLine(error);
    }
}

List<Product> products = new List<Product>();

while (true)
{
    Console.WriteLine("===== MENU =====");
    Console.WriteLine("1. Thêm sản phẩm");
    Console.WriteLine("2. Xem danh sách");
    Console.WriteLine("3. Tìm theo tên");
    Console.WriteLine("4. Cập nhật");
    Console.WriteLine("5. Xóa");
    Console.WriteLine("6. Lọc tồn kho thấp");
    Console.WriteLine("0. Thoát");

    Console.Write("Chọn: ");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            int id = products.Count + 1;

            Console.Write("Tên: ");
            string name = Console.ReadLine();

            Console.Write("Giá: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.Write("Số lượng: ");
            int quantity = int.Parse(Console.ReadLine());

            Product product = new Product(id, name, price, quantity);

            List<string> errorsday3 = validator.Validate(product);

            if (errorsday3.Count == 0)
            {
                products.Add(product);
                Console.WriteLine("Thêm thành công.");
            }
            else
            {
                foreach (string error in errorsday3)
                {
                    Console.WriteLine(error);
                }
            }

            break;

        case 2:

            foreach (Product p in products)
            {
                Console.WriteLine($"{p.Id} - {p.Name} - {p.Price} - {p.Quantity}");
            }

            break;

        case 3:

            Console.Write("Nhập tên cần tìm: ");
            string keyword = Console.ReadLine();

            var result = products.Where(p => p.Name.Contains(keyword));

            foreach (Product p in result)
            {
                Console.WriteLine($"{p.Id} - {p.Name} - {p.Price} - {p.Quantity}");
            }

            break;

        case 4:

            Console.Write("Nhập Id cần sửa: ");
            int updateId = int.Parse(Console.ReadLine());

            Product? updateProduct = products.Find(p => p.Id == updateId);

            if (updateProduct == null)
            {
                Console.WriteLine("Không tìm thấy.");
            }
            else
            {
                Console.Write("Giá mới: ");
                updateProduct.Price = decimal.Parse(Console.ReadLine());

                Console.Write("Số lượng mới: ");
                updateProduct.Quantity = int.Parse(Console.ReadLine());

                Console.WriteLine("Cập nhật thành công.");
            }

            break;

        case 5:

            Console.Write("Nhập Id cần xóa: ");
            int deleteId = int.Parse(Console.ReadLine());

            Product deleteProduct = products.Find(p => p.Id == deleteId);

            if (deleteProduct == null)
            {
                Console.WriteLine("Không tìm thấy.");
            }
            else
            {
                products.Remove(deleteProduct);
                Console.WriteLine("Xóa thành công.");
            }

            break;

        case 6:

            var lowStock = products.Where(p => p.Quantity < 5);

            foreach (Product p in lowStock)
            {
                Console.WriteLine($"{p.Id} - {p.Name} - {p.Quantity}");
            }

            break;

        case 0:
            return;

        default:
            Console.WriteLine("Lựa chọn không hợp lệ.");
            break;
    }
}