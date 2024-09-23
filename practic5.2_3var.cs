namespace pr52
{
    class Program
    {
        static int SumOfDivisors(int N)
        {
            int sum = 0;
            for (int i = 1; i * i <= N; i++)
            {
                if (N % i == 0) 
                {
                    sum += i;
                    if (i != N / i)
                    {
                        sum += N / i;
                    }
                }
            }
            return sum;
        }
        static void Main()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("a) для каждого целого числа на отрезке [a, b] вывести на экран сумму его делителей;");
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine($"{i}: {SumOfDivisors(i)}");
            }
            Console.WriteLine("");

            Console.WriteLine("b) вывести на экран только те целые числа отрезка [a, b], у которых сумма делителей равна заданному числу;");
            Console.Write("Введите число: ");
            int c = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                if (c == SumOfDivisors(i))
                {
                    Console.WriteLine($"{i}: {SumOfDivisors(i)}");
                }
            }
            Console.WriteLine("");

            Console.WriteLine("c) вывести на экран только те целые числа отрезка [a, b], у которых сумма делителей максимальна;");
            int max_sum = 0;
            List<int> num_max = new List<int>();
            for (int i = a; i <= b; i++)
            {
                int sum = SumOfDivisors(i);

                if (sum > max_sum)
                {
                    max_sum = sum;
                    num_max.Clear();
                    num_max.Add(i);
                }
                else if (sum == max_sum)
                {
                    num_max.Add(i);
                }
            }
            Console.WriteLine($"Максимальная сумма делителей: {max_sum}");
            Console.Write("Числа с этой суммой делителей: ");
            foreach (int num in num_max)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("d) для заданного числа А вывести на экран ближайшее предшествующее по отношению к нему число, сумма делителей которого равна сумме делителей числа А.");
            Console.Write("A = ");
            int A = int.Parse(Console.ReadLine());
            int sum_A = SumOfDivisors(A);
            for (int i = A - 1; i >= 1; i--)
            {
                if (SumOfDivisors(i) == sum_A)
                {
                    Console.WriteLine($"Число {i} имеет такую же сумму делителей: {sum_A}");
                    break;
                }
                else if (i == 1)
                {
                    Console.WriteLine("Не найдено предшествующее число с такой же суммой делителей.");
                }
            }
        }
    }
}


