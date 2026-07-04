Console.WriteLine("Tạo và in 5 sản phẩm ra màn hình ");
Product product1 = new Product(1,"táo",10000,9);
Product product2 = new Product(2,"ổi",10000,7);
Product product3 = new Product(3,"mít",10000,8);
Product product4 = new Product(4,"dưa",10000,6);
Product product5 = new Product(5,"chuối",10000,9);

Console.WriteLine($"Sản phẩn thứ {product1.Id} | Tên : {product1.Name} | Giá : {product1.Price} | Số Lượng : {product1.Quantity}");
Console.WriteLine($"Sản phẩn thứ {product2.Id} | Tên : {product2.Name} | Giá : {product2.Price} | Số Lượng : {product2.Quantity}");
Console.WriteLine($"Sản phẩn thứ {product3.Id} | Tên : {product3.Name} | Giá : {product3.Price} | Số Lượng : {product3.Quantity}");
Console.WriteLine($"Sản phẩn thứ {product4.Id} | Tên : {product4.Name} | Giá : {product4.Price} | Số Lượng : {product4.Quantity}");
Console.WriteLine($"Sản phẩn thứ {product5.Id} | Tên : {product5.Name} | Giá : {product5.Price} | Số Lượng : {product5.Quantity}");
Console.WriteLine($"Tổng tiền của sản phẩm 1 :{product1.TotalValue()}" );

Console.WriteLine("Tạo một học sinh để tính tuổi ");
Student student = new Student (1,"Nguyễn Hữu Hào", new DateOnly(2004, 4, 21));
Console.WriteLine($"Học sinh {student.Id} | Tên : {student.Name} | tuổi : {student.CalculateAge()} ");

