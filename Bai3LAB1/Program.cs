using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;  // Cấu hình đầu ra UTF-8
        Console.InputEncoding = Encoding.UTF8;   // Cấu hình đầu vào UTF-8

        Console.Write("Nhập nhiệt độ (°C): ");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"{celsius}°C bằng {fahrenheit}°F");
    }
}
