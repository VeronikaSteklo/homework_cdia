namespace pr763
{
    class Program
    {
        static int[][] Input(out int n, out int m)
        {
            Console.WriteLine("Введите количество строк:");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов:");
            Console.Write("m = ");
            m = int.Parse(Console.ReadLine());
            int[][] a = new int[n * 2][];
            for (int i = 0; i < n; i++)
            {
                a[i] = new int[m];
                for (int j = 0; j < m; j++)
                {
                    Console.Write("a[{0}][{1}]= ", i, j);
                    a[i][j] = int.Parse(Console.ReadLine());
                }
            }
            return a;
        }
        static void Print(int[][] a)
        {
            {
                foreach (var row in a)
                {
                    if (row != null)
                    {
                        Console.WriteLine(string.Join(" ", row));
                    }
                }
            }
        }
        static void Add(int[][] a, ref int n, int m, int k)
        {
            for (int i = n; i > k; i--)
            {
                a[i] = a[i - 1];
            }
            ++n;
            a[k] = new int[m];
            for (int j = 0; j < m; j++)
            {
                a[k][j] = 0;
            }
        }
        static void noEven(int[][] a, ref int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                bool hasEven = false;
                for (int j = 0; j < m; j++)
                {
                    if (a[i][j] % 2 == 0)
                    {
                        hasEven = true;
                        break;
                    }
                }

                if (!hasEven)
                {
                    Add(a, ref n, m, i + 1);
                    i++;
                }
            }
        }
        static void Main()
        {
            int n, m;
            int[][] a = Input(out n, out m);
            Console.WriteLine("Исходный массив:");
            Print(a);
           
            noEven(a, ref n, m);

            Console.WriteLine("Измененный массив:");
            Print(a);
        }
    }

}
