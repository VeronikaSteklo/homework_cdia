using System;

namespace Task18_19
{
    [Serializable]
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
}
