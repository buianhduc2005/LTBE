using System;

class Program
{
    static int SoLonThuHai(int[] arr)
    {
        int max = int.MinValue, second = int.MinValue;

        foreach (int x in arr)
        {
            if (x > max)
            {
                second = max;
                max = x;
            }
            else if (x > second && x < max)
            {
                second = x;
            }
        }

        return second;
    }

    static void Main()
    {
        int[] arr = { 5, 1, 9, 3, 9, 7 };
        Console.WriteLine("Số lớn thứ hai là: " + SoLonThuHai(arr));
    }
}
