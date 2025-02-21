using System;

namespace Task18_19
{
    [Serializable]
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
}
