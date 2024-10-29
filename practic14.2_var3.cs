using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BaggageClaim
{
    public struct Passenger : IComparable<Passenger>
    {
        public String Name;
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
            string inputFilePath = "C:\\Users\\veron\\source\\repos\\task9\\pass_input1.txt";
            string outputFilePath = "C:\\Users\\veron\\source\\repos\\task9\\output_pass.txt";
            double weightThreshold = 5.0;

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
                    double averageWeight = totalWeight / itemCount;

                    if (averageWeight > weightThreshold)
                    {
                        passengers.Add(new Passenger(name, itemCount, totalWeight, averageWeight));
                    }
                }
            }

            var filteredPassengers = passengers.OrderBy(passenger => passenger.ItemCount).ToList();

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
