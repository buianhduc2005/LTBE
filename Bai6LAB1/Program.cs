using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;  // Cấu hình đầu ra UTF-8
        Console.InputEncoding = Encoding.UTF8;   // Cấu hình đầu vào UTF-8

        Console.Write("Nhập một số: ");
        int number = int.Parse(Console.ReadLine());
        if (number > 0)
            Console.WriteLine("Số dương.");
        else if (number < 0)
            Console.WriteLine("Số âm.");
        else
            Console.WriteLine("Số không.");
    }
}

