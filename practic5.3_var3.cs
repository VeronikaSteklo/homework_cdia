namespace pr53
{
    class Program
    {

        static void Main()
        {
            Console.Write("Введите натуральное число: ");
            int num = int.Parse(Console.ReadLine());
            int coint = Coint_num(num);
            Console.WriteLine(coint);
        }

        static int Coint_num(int num)
        {
            if (num < 10)
            {
                return 1;
            }
            else
            {
                return 1 + Coint_num(num / 10);
            }
        }
    }
}
