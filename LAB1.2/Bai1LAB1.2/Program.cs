using System;

class Program
{
    static int TongChan(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
                sum += arr[i];
        }
        return sum;
    }

    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 6, 7 };
        Console.WriteLine("Tổng các số chẵn là: " + TongChan(arr));
    }
}

