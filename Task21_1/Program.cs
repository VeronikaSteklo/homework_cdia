using System;
using System.IO;

namespace Task21_1
{
    public class Program
    {
        static void Main()
        {
            string inputFile_left = "C:\\Users\\veron\\source\\repos\\Task21_1\\inputOnlyLeft.txt";
            string inputFile_right = "C:\\Users\\veron\\source\\repos\\Task21_1\\inputOnlyRight.txt";
            string inputFile_both = "C:\\Users\\veron\\source\\repos\\Task21_1\\inputBoth.txt";

            BinaryTree tree = new BinaryTree();
            Console.Write("Введите значение x: ");
            int x = int.Parse(Console.ReadLine());

            using (StreamReader fileIn = new StreamReader(inputFile_right))
            {
                string line = fileIn.ReadToEnd();
                char[] div = { ' ', ',', '.', '!', '?', ':', ';', '\t', '\n', '\r' };
                string[] data = line.Split(div, StringSplitOptions.RemoveEmptyEntries);

                foreach (string item in data)
                {
                    tree.Add(int.Parse(item));
                }
            }

            try
            {
                Console.WriteLine("Количество потомков у узла {0}: {1}", x, tree.CountDescendants(x));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}