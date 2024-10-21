using System;
using System.IO;

class Program
{
    static void Main()
    {
        string file1Contents;
        using (var reader1 = new StreamReader("C:\\Users\\veron\\source\\repos\\task9\\input_1.txt"))
        {
            file1Contents = reader1.ReadToEnd();
        }

        string file2Contents;
        using (var reader2 = new StreamReader("C:\\Users\\veron\\source\\repos\\task9\\input.txt"))
        {
            file2Contents = reader2.ReadToEnd();
        }

        using (var writerTemp = new StreamWriter("C:\\Users\\veron\\source\\repos\\task9\\temp.txt"))
        {
            writerTemp.Write(file2Contents);
        }

        using (var writer2 = new StreamWriter("C:\\Users\\veron\\source\\repos\\task9\\input.txt"))
        {
            writer2.Write(file1Contents);
        }

        using (var writer1 = new StreamWriter("C:\\Users\\veron\\source\\repos\\task9\\input_1.txt"))
        {
            using (var readerTemp = new StreamReader("C:\\Users\\veron\\source\\repos\\task9\\temp.txt"))
            {
                string tempContents = readerTemp.ReadToEnd();
                writer1.Write(tempContents);
            }
        }

        File.Delete("C:\\Users\\veron\\source\\repos\\task9\\temp.txt");

        Console.WriteLine("Содержимое файлов успешно поменяно местами.");
    }
}
