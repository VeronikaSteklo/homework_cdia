using System;
using System.IO;

namespace Task20
{
    
    public class Program
    {
        static void Main()
        {
            string inputFile = "D:\\шарпы\\уник\\Task20\\input.txt";
            string outputFile = "D:\\шарпы\\уник\\Task20\\output.txt";

            List list = new List();

            using (StreamReader fileIn = new StreamReader(inputFile))
            {
                string line = fileIn.ReadToEnd();
                char[] div = { ' ', ',', '.', '!', '?', ':', ';', '\t', '\n', '\r' };
                string[] data = line.Split(div, StringSplitOptions.RemoveEmptyEntries);

                foreach (string item in data)
                {
                    list.AddEnd(int.Parse(item));
                }
            }
            
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());
            
            Node r = list.Find(x); 
            
            while (r != null) 
            {
                list.Insert(r, y);
                r = r.Next.Next;
                r = list.Find(r, x);
            }
            
            list.Show(outputFile);
        }
    }


}
