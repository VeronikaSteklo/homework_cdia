using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Task18_19
{

    class Program
    {
        static void Main()
        {
            string binaryFile = "C:\\Users\\veron\\source\\repos\\task9\\publications_all.dat";
            List<Publication> catalog = new List<Publication>();
            BinaryFormatter formatter = new BinaryFormatter();

            if (File.Exists(binaryFile))
            {
                using (FileStream fs = new FileStream(binaryFile, FileMode.OpenOrCreate))
                {
                    if (fs.Length > 0)
                    {
                        catalog = (List<Publication>)formatter.Deserialize(fs);
                    }
                }
            }

            Console.Write("\nВведите количество изданий для добавления в каталог: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите тип издания (Book, Article, EResource): ");
                string type = Console.ReadLine();
                Console.Write("Введите название: ");
                string title = Console.ReadLine();
                Console.Write("Введите автора: ");
                string author = Console.ReadLine();

                switch (type)
                {
                    case "Book":
                        Console.Write("Введите год издания: ");
                        int year = int.Parse(Console.ReadLine());
                        Console.Write("Введите издательство: ");
                        string publisher = Console.ReadLine();
                        catalog.Add(new Book(title, author, year, publisher));
                        break;
                    case "Article":
                        Console.Write("Введите название журнала: ");
                        string journal = Console.ReadLine();
                        Console.Write("Введите номер выпуска: ");
                        int issue = int.Parse(Console.ReadLine());
                        Console.Write("Введите год издания: ");
                        int articleYear = int.Parse(Console.ReadLine());
                        catalog.Add(new Article(title, author, journal, issue, articleYear));
                        break;
                    case "EResource":
                        Console.Write("Введите ссылку: ");
                        string link = Console.ReadLine();
                        Console.Write("Введите аннотацию: ");
                        string annotation = Console.ReadLine();
                        catalog.Add(new EResource(title, author, link, annotation));
                        break;
                }
            }

            Console.WriteLine("\nПолная информация о каталоге:");
            foreach (var pub in catalog)
            {
                Console.WriteLine(pub);
            }

            catalog.Sort();

            using (FileStream fs = new FileStream(binaryFile, FileMode.Create))
            {
                formatter.Serialize(fs, catalog);
            }


            Console.Write("\nВведите фамилию автора для поиска: ");
            string searchAuthor = Console.ReadLine();
            bool found = false;

            Console.WriteLine($"\nРезультаты поиска для автора '{searchAuthor}':");
            foreach (var pub in catalog)
            {
                if (pub.IsMatch(searchAuthor))
                {
                    Console.WriteLine(pub);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Ничего не найдено.");
            }

            Console.WriteLine($"\nКаталог обновлен и сохранен в файл: {binaryFile}");
            Console.ReadLine();
        }
    }
}
