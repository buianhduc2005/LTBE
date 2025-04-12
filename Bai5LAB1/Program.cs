using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;  // Cấu hình đầu ra UTF-8
        Console.InputEncoding = Encoding.UTF8;   // Cấu hình đầu vào UTF-8

        Console.Write("Nhập số thứ nhất: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Nhập số thứ hai: ");
        int num2 = int.Parse(Console.ReadLine());
        int sum = num1 + num2;
        int product = num1 * num2;
        Console.WriteLine($"Tổng: {sum}, Tích: {product}");
    }
}
