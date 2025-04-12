using System;

class Program
{
    static void HoanVi(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        Console.Write("Nhập a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhập b = ");
        int b = int.Parse(Console.ReadLine());

        HoanVi(ref a, ref b);
        Console.WriteLine($"Sau hoán vị: a = {a}, b = {b}");
    }
}
