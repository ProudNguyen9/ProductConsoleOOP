public class ProductValidator
{
    public List<string> Validate(Product product)
    {
        List<string> errors = new List<string>();

        if (string.IsNullOrWhiteSpace(product.Name))
        {
            errors.Add("Tên sản phẩm không được để trống.");
        }

        if (product.Price <= 0)
        {
            errors.Add("Giá sản phẩm phải lớn hơn 0.");
        }

        if (product.Quantity < 0)
        {
            errors.Add("Số lượng không được nhỏ hơn 0.");
        }

        return errors;
    }
}