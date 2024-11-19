using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string inputFilePath = "C:\\Users\\veron\\source\\repos\\task9\\input_ez.txt";
        string outputFilePath = "C:\\Users\\veron\\source\\repos\\task9\\output.txt"; 

        Console.WriteLine("Введите начало отрезка (a):");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите конец отрезка (b):");
        int b = int.Parse(Console.ReadLine());

        try
        {
            List<int> numbers = new List<int>();

            using (var reader2 = new StreamReader(inputFilePath))
            {

                string line;
                while ((line = reader2.ReadLine()) != null)
                {
                    numbers.AddRange(line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                         .Select(int.Parse));
                }
            }


            var filteredNumbers = numbers.Where(num => num >= a && num <= b)
                                         .OrderBy(num => num)
                                         .ToList();

            Console.WriteLine("Числа из отрезка [{0}, {1}], отсортированные по возрастанию:", a, b);
            Console.WriteLine(string.Join(" ", filteredNumbers));

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (var num in filteredNumbers)
                {
                    writer.Write($" {num}");
                }
            }

            Console.WriteLine($"Результат сохранен в файл: {outputFilePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка: " + ex.Message);
        }
    }
}
