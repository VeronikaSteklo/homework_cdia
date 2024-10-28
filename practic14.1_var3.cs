using System;
using System.Collections.Generic;
using System.IO;

namespace MyProgram
{
    struct SPoint : IComparable<SPoint>
    {
        public int x, y;

        public SPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Show()
        {
            Console.WriteLine("({0}, {1})", x, y);
        }

        public double Distance()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public int CompareTo(SPoint obj)
        {
            if (this.Distance() == obj.Distance())
            {
                return 0;
            }
            else if (this.Distance() > obj.Distance())
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "C:\\Users\\veron\\source\\repos\\task9\\input_ez.txt";
            string outputFile = "C:\\Users\\veron\\source\\repos\\task9\\closest_points.txt";

            List<SPoint> points = ReadPointsFromFile(inputFile);
            List<SPoint> closestPoints = FindClosestPoints(points);

            Console.WriteLine("Точки, наименее удаленные от начала координат:");
            foreach (var point in closestPoints)
            {
                point.Show();
            }

            WritePointsToFile(outputFile, closestPoints);
        }

        static List<SPoint> ReadPointsFromFile(string filePath)
        {
            List<SPoint> points = new List<SPoint>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(' ');
                        if (parts.Length == 2 &&
                            int.TryParse(parts[0], out int x) &&
                            int.TryParse(parts[1], out int y))
                        {
                            points.Add(new SPoint(x, y));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка чтения файла: {ex.Message}");
            }

            return points;
        }

        static List<SPoint> FindClosestPoints(List<SPoint> points)
        {
            if (points == null || points.Count == 0)
            {
                throw new ArgumentException("Список точек не может быть пустым");
            }

            List<SPoint> closestPoints = new List<SPoint>();
            double minDistance = points[0].Distance();

            foreach (SPoint point in points)
            {
                double distance = point.Distance();
                if (distance < minDistance)
                {
                    minDistance = distance;
                    closestPoints.Clear();
                    closestPoints.Add(point);
                }
                else if (distance == minDistance)
                {
                    closestPoints.Add(point);
                }
            }

            return closestPoints;
        }

        static void WritePointsToFile(string filePath, List<SPoint> points)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var point in points)
                    {
                        writer.WriteLine($"{point.x}, {point.y}");
                    }
                }
                Console.WriteLine("Результат записан в файл.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка записи в файл: {ex.Message}");
            }
        }
    }
}
