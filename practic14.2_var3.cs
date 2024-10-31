using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text;
using System.IO;

namespace BaggageClaim
{
    public struct Passenger : IComparable<Passenger>
    {
        public string Name;
        public int ItemCount;
        public double TotalWeight;
        public double AverageWeight;

        public Passenger(string name, int itemCount, double totalWeight, double averageWeight)
        {
            this.Name = name;
            this.ItemCount = itemCount;
            this.TotalWeight = totalWeight;
            this.AverageWeight = averageWeight;
        }

        public int CompareTo(Passenger other)
        {
            return this.ItemCount.CompareTo(other.ItemCount);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            string inputFilePath = "C:\\Users\\veron\\source\\repos\\task9\\pass_input1.txt";
            string outputFilePath = "C:\\Users\\veron\\source\\repos\\task9\\output_pass.txt";
            double weightThreshold = 5.0;

            List<Passenger> passengers = new List<Passenger>();

            using (StreamReader reader = new StreamReader(inputFilePath, Encoding.GetEncoding(1251)))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    var data = line.Split(';');

                    if (data.Length < 3)
                    {
                        Console.WriteLine("Ошибка формата строки: " + line);
                        continue;
                    }

                    string name = data[0].Trim();
                    int itemCount = int.Parse(data[1].Trim());
                    double totalWeight = double.Parse(data[2].Trim());
                    double averageWeight = totalWeight / itemCount;

                    if (averageWeight > weightThreshold)
                    {
                        Console.WriteLine(name);
                        passengers.Add(new Passenger(name, itemCount, totalWeight, averageWeight));
                    }
                }
            }

            passengers.Sort();

            using (var writer = new StreamWriter(outputFilePath, false, Encoding.Default))
            {
                if (passengers.Count == 0)
                {
                    writer.WriteLine("Пассажиров нет");
                }
                foreach (var passenger in passengers)
                {
                    string name = passenger.Name;
                    writer.WriteLine($"{name}; {passenger.ItemCount}; {passenger.TotalWeight}; Средний вес: {passenger.AverageWeight:F2}");
                }
            }

            Console.WriteLine("Фильтрация и запись данных выполнены успешно.");
        }
    }
}
