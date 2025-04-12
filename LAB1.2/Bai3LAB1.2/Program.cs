using System;

class Program
{
    static void DemAmDuong(int[] arr, out int soAm, out int soDuong)
    {
        soAm = 0;
        soDuong = 0;
        foreach (int x in arr)
        {
            if (x > 0) soDuong++;
            else if (x < 0) soAm++;
        }
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

        int soAm, soDuong;
        DemAmDuong(arr, out soAm, out soDuong);
        Console.WriteLine("Số âm: " + soAm);
        Console.WriteLine("Số dương: " + soDuong);
    }
}
