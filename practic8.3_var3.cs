namespace pr833
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            char[] div = { ' ', ',', '.', '!', '?', ':', ';' };
            string[] words = input.Split(div, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("\nСлова, начинающиеся с прописной буквы:");

            foreach (string word in words)
            {
                if (char.IsUpper(word[0]))
                {
                    Console.WriteLine(word);
                }
            }
        }
    }

}
