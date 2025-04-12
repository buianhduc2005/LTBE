using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;  // Cấu hình đầu ra UTF-8
        Console.InputEncoding = Encoding.UTF8;   // Cấu hình đầu vào UTF-8

        Console.Write("Nhập một số: ");
        int num = int.Parse(Console.ReadLine());
        bool isPrime = true;

        if (num <= 1)
            isPrime = false;
        else
        {
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
            Console.WriteLine($"{num} là số nguyên tố.");
        else
            Console.WriteLine($"{num} không phải là số nguyên tố.");
    }
}

