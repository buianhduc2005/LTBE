using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;  // Cấu hình đầu ra UTF-8
        

        Console.Write("Nhập tên: ");
        string name = Console.ReadLine();
        Console.Write("Nhập tuổi: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine($"Xin chào {name}, bạn {age} tuổi!");
    }
}




