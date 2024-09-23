namespace pr54
{
    class Program
    {
        
        static void Main()
        {
            Console.Write("Введите количество лунатиков: ");
            int num = int.Parse(Console.ReadLine());
            Print_poem(num);
        }

        static void Print_poem(int num)
        {
            if (num == 0)
            {
                Console.WriteLine("И больше лунатиков не стало на луне");
                return;
            }
            Console.WriteLine($"{num} лунатиков жили на луне");
            Console.WriteLine($"{num} лунатиков ворочались во сне");
            Console.WriteLine("Один из лунатиков упал с луны во сне");
            Console.WriteLine($"{num - 1} лунатиков осталось на луне");
            Print_poem(num - 1);
        }
    }
}


