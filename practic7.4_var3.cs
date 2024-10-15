namespace pr743
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите размер массива n: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Элемент [{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int[] X = new int[n];

            Console.WriteLine("Введите элементы вектора X:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Элемент X[{i}]: ");
                X[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Исходный массив:");
            PrintMatrix(matrix, n);

            for (int j = 0; j < n; j++)
            {
                if (j % 2 == 0)
                {
                    for (int i = 0; i < n; i++)
                    {
                        matrix[i, j] = X[i];
                    }
                }
            }

            Console.WriteLine("Измененный массив:");
            PrintMatrix(matrix, n);
        }

        static void PrintMatrix(int[,] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}
