using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Rectangle
    {
        private int a, b;

        public Rectangle()
        {
            a = 1;
            b = 1;
        }

        public Rectangle(int a, int b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new ArgumentException("Стороны должны быть положительными.");
            }
            this.a = a;
            this.b = b;
        }

        public Rectangle(Rectangle rect)
        {
            this.a = rect.a;
            this.b = rect.b;
        }

        public int CalculatePerimeter()
        {
            return 2 * (a + b);
        }

        public static int CalculateArea(int a, int b)
        {
            return a * b;
        }

        public void Scale(double factor)
        {
            if (factor <= 0)
            {
                throw new ArgumentException("Коэффициент должен быть положительным.");
            }
            a = (int)(a * factor);
            b = (int)(b * factor);
        }

        public int A
        {
            get => a;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Стороны должны быть положительными.");
                }
                a = value;
            }
        }

        public int B
        {
            get => b;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Стороны должны быть положительными.");
                }
                b = value;
            }
        }

        public bool IsSquare()
        {
            return a == b;
        }

        public int this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return a;
                }
                else if (index == 1)
                {
                    return b;
                }
                else
                {
                    throw new IndexOutOfRangeException("Допустимые индексы: 0 и 1.");
                }
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Стороны должны быть положительными.");
                }
                if (index == 0)
                {
                    a = value;
                }
                else if (index == 1)
                {
                    b = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Допустимые индексы: 0 и 1.");
                }
            }
        }

        public static Rectangle operator ++(Rectangle rect)
        {
            rect.a++;
            rect.b++;
            return rect;
        }

        public static Rectangle operator --(Rectangle rect)
        {
            rect.a--;
            rect.b--;
            return rect;
        }

        public static Rectangle operator *(Rectangle rect, int scalar)
        {
            rect.a *= scalar;
            rect.b *= scalar;
            return rect;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(a, b);
        }

        public override bool Equals(object obj)
        {
            if (obj is Rectangle other)
            {
                return a == other.a && b == other.b;
            }
            return false;
        }

        //public override Type GetType()
        //{
        //    return typeof(Rectangle);
        //}

        public override string ToString()
        {
            return $"Прямоугольник: a={a}, b={b}, Площадь={CalculateArea(a, b)}, Периметр={CalculatePerimeter()}, Квадрат: {(IsSquare() ? "да": "нет")}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = "C:\\Users\\veron\\source\\repos\\task9\\input_ez.txt";
            string outputFilePath = "C:\\Users\\veron\\source\\repos\\task9\\output17.txt";

            List<Rectangle> rectangles = new List<Rectangle>();

            try
            {
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
               
                using (StreamReader reader = new StreamReader(inputFilePath, Encoding.UTF8))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(' ');
                        if (parts.Length == 2 &&
                            int.TryParse(parts[0], out int x) &&
                            int.TryParse(parts[1], out int y))
                        {
                            rectangles.Add(new Rectangle(x, y));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка чтения файла: {ex.Message}");
            }

            WriteRectangleToFile(outputFilePath, rectangles);

            static void WriteRectangleToFile(string filePath, List<Rectangle> rectangles)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        int i = 1; 
                        Rectangle prev = rectangles[0];
                        
                        foreach (var rectangle in rectangles)
                        {
                            writer.WriteLine($"{i}. {rectangle}" );
                            rectangle.Scale(i);
                            writer.WriteLine($"После умножения на скаляр: {rectangle}");
                            writer.WriteLine($"HashCode: {rectangle.GetHashCode()}");
                            writer.WriteLine($"Равность предыдущему: {rectangle.Equals(prev)}");
                            prev = rectangles[i - 1];
                            i++;
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
}
