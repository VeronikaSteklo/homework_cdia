using System;
using System.IO;
using System.Text;

namespace Task18_19
{
    abstract class Publication : IComparable<Publication>
    {
        public string Title { get; set; }
        public string Author { get; set; }

        protected Publication(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public abstract string ToString();
        
        public abstract bool IsMatch(string author);

        public int CompareTo(Publication other)
        {
            return string.Compare(Author, other.Author, StringComparison.OrdinalIgnoreCase);
        }
    }

    class Book : Publication
    {
        public int Year { get; set; }
        public string Publisher { get; set; }

        public Book(string title, string author, int year, string publisher)
            : base(title, author)
        {
            Year = year;
            Publisher = publisher;
        }

        public override string ToString()
        {
            return $"Книга: {Title}, Автор: {Author}, Год: {Year}, Издательство: {Publisher}";
        }

        public override bool IsMatch(string author)
        {
            return Author.Equals(author, StringComparison.OrdinalIgnoreCase);
        }
    }

    class Article : Publication
    {
        public string Journal { get; set; }
        public int Issue { get; set; }
        public int Year { get; set; }

        public Article(string title, string author, string journal, int issue, int year)
            : base(title, author)
        {
            Journal = journal;
            Issue = issue;
            Year = year;
        }

        public override string ToString()
        {
            return $"Статья: {Title}, Автор: {Author}, Журнал: {Journal}, Номер: {Issue}, Год: {Year}";
        }

        public override bool IsMatch(string author)
        {
            return Author.Equals(author, StringComparison.OrdinalIgnoreCase);
        }
    }

    class EResource : Publication
    {
        public string Link { get; set; }
        public string Annotation { get; set; }

        public EResource(string title, string author, string link, string annotation)
            : base(title, author)
        {
            Link = link;
            Annotation = annotation;
        }

        public override string ToString()
        {
            return $"Электронный ресурс: {Title}, Автор: {Author}, Ссылка: {Link}, Аннотация: {Annotation}";
        }

        public override bool IsMatch(string author)
        {
            return Author.Equals(author, StringComparison.OrdinalIgnoreCase);
        }
    }

    class Program
    {
        static void Main()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            string input_file = "C:\\Users\\veron\\source\\repos\\task9\\publications.txt";
            string output_file = "C:\\Users\\veron\\source\\repos\\task9\\output_18_19.txt";

            string[] lines = File.ReadAllLines(input_file, Encoding.GetEncoding(1251));
            Publication[] catalog = new Publication[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(';');
                string type = parts[0];

                switch (type)
                {
                    case "Book":
                        catalog[i] = new Book(parts[1], parts[2], int.Parse(parts[3]), parts[4]);
                        break;
                    case "Article":
                        catalog[i] = new Article(parts[1], parts[2], parts[3], int.Parse(parts[4]), int.Parse(parts[5]));
                        break;
                    case "EResource":
                        catalog[i] = new EResource(parts[1], parts[2], parts[3], parts[4]);
                        break;
                }
            }

            using (var writer = new StreamWriter(output_file))
            {
                writer.WriteLine("Полная информация о каталоге:");
                foreach (var publication in catalog)
                {
                    string info = publication.ToString();
                    writer.WriteLine(info);
                }

                Array.Sort(catalog);

                Console.Write("Введите фамилию автора для поиска: ");
                string searchAuthor = Console.ReadLine();
                bool found = false;

                Array.Sort(catalog);

                writer.WriteLine("\nОтсортированный каталог:");
                foreach (var publication in catalog)
                {
                    string info = publication.ToString();
                    writer.WriteLine(info);
                }

                writer.WriteLine($"\nРезультаты поиска для автора '{searchAuthor}':");
                foreach (var publication in catalog)
                {
                    if (publication.IsMatch(searchAuthor))
                    {
                        string info = publication.ToString();
                        writer.WriteLine(info);
                        found = true;
                    }
                }

                if (!found)
                {
                    writer.WriteLine("Ничего не найдено.");
                }
            }

            Console.WriteLine($"\nРезультаты записаны в файл: {output_file}");
        }
    }
}
