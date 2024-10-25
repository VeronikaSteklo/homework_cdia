using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int[] aValues = { 3, 11, 3517, 4, 105, 12012, 9979200 };
        int[] bValues = { 4, 3571, 3461, 12, 30, 27720, 1048950 };

        for (int i = 0; i < aValues.Length; i++)
        {
            int a = aValues[i];
            int b = bValues[i];

            Stopwatch sw1 = Stopwatch.StartNew();
            int gcdSub = GCDSubtraction(a, b);
            sw1.Stop();

            Stopwatch sw2 = Stopwatch.StartNew();
            int gcdDiv = GCDDivision(a, b);
            sw2.Stop();

            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"GCD ( сложение ): {gcdSub}, Время: {sw1.ElapsedTicks} тиков");
            Console.WriteLine($"GCD ( деление ): {gcdDiv}, Время: {sw2.ElapsedTicks} тиков");
            Console.WriteLine();
        }
    }

    public static int GCDSubtraction(int a, int b)
    {
        while (a != b)
        {
            if (a > b)
            {
                a -= b;
            }
            else
            {
                b -= a;
            }
        }
        return a;
    }

    public static int GCDDivision(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
