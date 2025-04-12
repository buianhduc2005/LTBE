using System;

class Program
{
    static void SapXepTang(double[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    double temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }

    static void Main()
    {
        Console.Write("Nhập số phần tử: ");
        int n = int.Parse(Console.ReadLine());
        double[] arr = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}] = ");
            arr[i] = double.Parse(Console.ReadLine());
        }

        SapXepTang(arr);

        Console.WriteLine("Mảng sau khi sắp xếp tăng dần:");
        foreach (double x in arr)
            Console.Write(x + " ");
    }
}
