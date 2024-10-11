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

            List<int[]> resultMatrix = new List<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] row = new int[n];
                for (int j = 0; j < n; j++)
                {
                    row[j] = matrix[i, j];
                }

                resultMatrix.Add(row);

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
                    resultMatrix.Add(new int[n]);
                }
            }

            Console.WriteLine("Измененный массив:");
            PrintMatrix(resultMatrix);
        }

        static void PrintMatrix(List<int[]> matrix)
        {
            foreach (var row in matrix)
            {
                foreach (var element in row)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
