using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BaggageClaim
{
    public struct Passenger : IComparable<Passenger>
    {
        public string Name { get; set; }
        public int ItemCount { get; set; }
        public double TotalWeight { get; set; }

        public Passenger(string name, int itemCount, double totalWeight)
        {
            Name = name;
            ItemCount = itemCount;
            TotalWeight = totalWeight;
        }

        public double AverageWeight => TotalWeight / ItemCount;

        public int CompareTo(Passenger other)
        {
            return this.ItemCount.CompareTo(other.ItemCount);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = "C:\\Users\\veron\\source\\repos\\task9\\pass_input1.txt";
            string outputFilePath = "C:\\Users\\veron\\source\\repos\\task9\\output_pass.txt";
            double weightThreshold = 2.0; 

            List<Passenger> passengers = new List<Passenger>();

            using (var reader = new StreamReader(inputFilePath, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var data = line.Split(';');
                    string name = data[0].Trim();
                    int itemCount = int.Parse(data[1].Trim());
                    double totalWeight = double.Parse(data[2].Trim());

                    passengers.Add(new Passenger(name, itemCount, totalWeight));
                }
            }

            var filteredPassengers = passengers
                .Where(p => p.AverageWeight > weightThreshold)
                .OrderBy(p => p.ItemCount)
                .ToList();

            using (var writer = new StreamWriter(outputFilePath, false, Encoding.UTF8))
            {
                if (filteredPassengers.Count == 0)
                {
                    writer.WriteLine("Пассажирова нет");
                }
                foreach (var passenger in filteredPassengers)
                {
                    writer.WriteLine($"{passenger.Name}; {passenger.ItemCount}; {passenger.TotalWeight}; Средний вес: {passenger.AverageWeight:F2}");
                }
            }

            Console.WriteLine("Фильтрация и запись данных выполнены успешно.");
        }
    }
}
