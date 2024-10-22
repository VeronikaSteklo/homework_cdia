using System;
using System.IO;
using static System.Net.WebRequestMethods;
using System;
using System.Text;
using System.IO;

class Program
{
    static void Main()
    {
        string file1 = "C:\\Users\\veron\\source\\repos\\task9\\input_1.txt";
        string file2 = "C:\\Users\\veron\\source\\repos\\task9\\input.txt";
        string fileTemp = "C:\\Users\\veron\\source\\repos\\task9\\temp.txt";

        using (var reader1 = new StreamReader(file1))
        {
            using (StreamWriter temp = new StreamWriter(fileTemp))
            {
                string line;
                while ((line = reader1.ReadLine()) != null)
                {
                    temp.WriteLine(line);
                }
            }
        }

        using (var reader2 = new StreamReader(file2))
        {
            using (StreamWriter writer1 = new StreamWriter(file1))
            {
                string line;
                while ((line = reader2.ReadLine()) != null)
                {
                    writer1.WriteLine(line);
                }
            }

        }

        using (var reader2 = new StreamReader(fileTemp))
        {
            using (StreamWriter writer1 = new StreamWriter(file2))
            {
                string line;
                while ((line = reader2.ReadLine()) != null)
                {
                    writer1.WriteLine(line);
                }
            }

        }


        Console.WriteLine("Содержимое файлов успешно поменяно местами.");
    }
}
