using System;

class Program
{
    static bool LaSoNguyenTo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0) return false;
        return true;
    }

    static void Main()
    {
        Console.Write("Nhập số phần tử: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}] = ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Các số nguyên tố trong mảng:");
        for (int i = 0; i < n; i++)
        {
            if (LaSoNguyenTo(arr[i]))
                Console.WriteLine($"arr[{i}] = {arr[i]}");
        }
    }
}
