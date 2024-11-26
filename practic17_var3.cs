using System;
using System.Collections.Generic;
using System.Text;

namespace Task17
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
            get
            {
                return a;
            }
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
            get 
            {
                return b;
            }
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
            Rectangle rectangle = new Rectangle(rect);
            rectangle.a++;
            rectangle.b++;
            return rectangle;
        }

        public static Rectangle operator --(Rectangle rect)
        {
            Rectangle rectangle = new Rectangle(rect);
            --rectangle.a;
            --rectangle.b;
            if (rectangle.a <= 0 || rectangle.b <= 0)
            {
                throw new ArgumentException("Стороны должны быть положительными.");
            }
            else
            {
                return rectangle;
            }
        }

        public static Rectangle operator *(Rectangle rect, int scalar)
        {
            Rectangle rectangle = new Rectangle(rect);
            if (scalar <= 0)
            {
                throw new ArgumentException("Скаляр должен быть положительным.");
            }
            else
            {
                rectangle.a *= scalar;
                rectangle.b *= scalar;
                return rectangle;
            }
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
                        Rectangle prev = new Rectangle(10, 5);
                        
                        foreach (var rectangle in rectangles)
                        {
                            int i = rectangles.IndexOf(rectangle) + 1;
                            writer.WriteLine($"{i}. {rectangle}" );

                            writer.WriteLine("\nПерегрузки методов предков:");
                            writer.WriteLine($"ToString: {rectangle.ToString()}");
                            writer.WriteLine($"HashCode: {rectangle.GetHashCode()}");
                            writer.WriteLine($"Равность: {rectangle.Equals(prev)}");

                            rectangle.Scale(i);
                            writer.WriteLine($"После умножения на скаляр: {rectangle}");

                            rectangle[0] = i * 2;
                            rectangle[1] = i * 3;
                            writer.WriteLine($"\nИндексатор: {rectangle}");

                            Rectangle temp = new Rectangle(rectangle);
                            writer.WriteLine($"\n{temp}\nПерегрузки:");
                            --temp;
                            writer.WriteLine($"--: {temp}");
                            ++temp;
                            writer.WriteLine($"++: {temp}");
                            temp *= 2;
                            writer.WriteLine($"*= 2: {temp}");
                            writer.WriteLine($"Копирование, а не присваивание одной ссылки: \n{rectangle}");

                            writer.WriteLine($"\n\n");
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
