using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    public class MainProgram
    {
        static void Main()
        {
            // Считываем n из консоли
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            string inputFile_left = "C:\\Users\\veron\\source\\repos\\tasks\\inputOnlyLeft.txt";
            string inputFile_right = "C:\\Users\\veron\\source\\repos\\tasks\\inputOnlyRight.txt";
            string inputFile_both = "C:\\Users\\veron\\source\\repos\\tasks\\inputBoth.txt";
            string inputFile = "C:\\Users\\veron\\source\\repos\\tasks\\input_1.txt";

            BinaryTree tree = new BinaryTree();

            using (StreamReader fileIn = new StreamReader(inputFile))
            {
                string line = fileIn.ReadToEnd();
                char[] div = { ' ', ',', '.', '!', '?', ':', ';', '\t', '\n', '\r' };
                string[] data = line.Split(div, StringSplitOptions.RemoveEmptyEntries);

                foreach (string item in data)
                {
                    tree.Add(int.Parse(item));
                }
            }

            Console.WriteLine("Дерево до балансировки:");
            tree.Preorder();
            Console.WriteLine();

            Queue<Node> unbalancedNode = tree.GetUnbalancedNodes();

            List<Node> removedNodes;
            bool isBalanced = tree.TryBalanceTree(n, out removedNodes);

            if (isBalanced)
            {
                Console.WriteLine("Дерево сбалансировано!");
            }
            else
            {
                Console.WriteLine("Не удалось сбалансировать дерево.");
            }

            Console.WriteLine("\nУдаленные узлы:");
            foreach (var node in removedNodes)
            {
                Console.Write(node.inf + " ");
            }

            Console.WriteLine("\n\nДерево после балансировки:");
            tree.Preorder();
        }
    }
    
}
