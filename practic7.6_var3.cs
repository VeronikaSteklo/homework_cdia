namespace pr763
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
            PrintMatrix(matrix);

            matrix = NoEvenRows(matrix, n);

            Console.WriteLine("\nМатрица после вставки строк:");
            PrintMatrix(matrix);
        }

        static int[,] NoEvenRows(int[,] matrix, int n)
        {
            int no_even = 0;
            List<int> no_even_list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                bool hasEven = false;
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        hasEven = true;
                        break;
                    }
                }

                if (!hasEven)
                {
                    no_even++;
                    no_even_list.Add(i);
                }
            }

            int[,] resultMatrix = new int[n + no_even, n];

            int plus = 0; 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    resultMatrix[i + plus, j] = matrix[i, j];
                }

                if (no_even_list.Contains(i))
                {
                    plus++;
                    for (int j = 0; j < n; j++)
                    {
                        resultMatrix[i + plus, j] = 0;
                    }
                }
            }

            return resultMatrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
