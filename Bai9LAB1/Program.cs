using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;  // Cấu hình đầu ra UTF-8
        Console.InputEncoding = Encoding.UTF8;   // Cấu hình đầu vào UTF-8

        Console.Write("Nhập một số nguyên dương: ");
        int n = int.Parse(Console.ReadLine());
        long factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine($"Giai thừa của {n} là: {factorial}");
    }
}

