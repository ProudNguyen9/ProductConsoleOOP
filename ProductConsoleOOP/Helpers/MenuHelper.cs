public static class MenuHelper
{

    public static int ReadInt(string message)
    {
        int value;
        Console.Write(message);
        while (!int.TryParse(Console.ReadLine(), out value))
        {
            Console.Write("Không hợp lệ. Nhập lại: ");
        }
        return value;
    }
    public static decimal ReadDecimal(string message)
    {
        decimal value;
        Console.Write(message);
        while (!decimal.TryParse(Console.ReadLine(), out value))
        {
            Console.Write("Không hợp lệ. Nhập lại: ");
        }
        return value;
    }
    public static string ReadString(string message)
{
    string? value;

    Console.Write(message);

    value = Console.ReadLine();

    while (string.IsNullOrWhiteSpace(value))
    {
        Console.Write("Không hợp lệ. Nhập lại: ");
        value = Console.ReadLine();
    }

    return value;
}
}