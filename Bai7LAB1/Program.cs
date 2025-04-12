using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;  // Cấu hình đầu ra UTF-8
        Console.InputEncoding = Encoding.UTF8;   // Cấu hình đầu vào UTF-8

        Console.Write("Nhập năm: ");
        int year = int.Parse(Console.ReadLine());
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            Console.WriteLine("Năm nhuận.");
        else
            Console.WriteLine("Không phải năm nhuận.");
    }
}
