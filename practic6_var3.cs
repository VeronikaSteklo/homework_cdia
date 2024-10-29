using System;
using System.Diagnostics;

public class GCDTest
{
    public static void Main()
    {
        var testCases = new (int, int)[] 
        {
            (3, 4), (11, 3571), (3517, 3461), (4, 12),
            (105, 30), (12012, 27720), (9979200, 1048950)
        };


        foreach (var (a, b) in testCases)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            GCDSubtraction(a, b);
            stopwatch.Stop();
            long subtractionTime = stopwatch.ElapsedTicks;

            stopwatch.Restart();
            GCDDivision(a, b);
            stopwatch.Stop();
            long divisionTime = stopwatch.ElapsedTicks;

            Console.WriteLine($"Значения a и b: {a} и {b} \nВремя вычитания: {subtractionTime} \nВремя деления: {divisionTime}\n");
        }
    }

    public static int GCDSubtraction(int a, int b)
    {
        while (a != b)
        {
            if (a > b)
                a -= b;
            else
                b -= a;
        }
        return a;
    }

    public static int GCDDivision(int a, int b)
    {
        while (b != 0)
        {
            int remainder = a % b;
            a = b;
            b = remainder;
        }
        return a;
    }
}
