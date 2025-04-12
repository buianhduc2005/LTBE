using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;  // Cấu hình đầu ra UTF-8
        

        Console.Write("Nhập chiều dài: ");
        double length = double.Parse(Console.ReadLine());
        Console.Write("Nhập chiều rộng: ");
        double width = double.Parse(Console.ReadLine());
        double area = length * width;
        Console.WriteLine($"Diện tích hình chữ nhật là: {area}");
    }
}

