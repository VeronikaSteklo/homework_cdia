using Newtonsoft.Json;

namespace Task18_19.DataAccessLayer.Entities;

public class Article : Publication
{
    public string Journal { get; set; }
    public int Issue { get; set; }
    public int Year { get; set; }
    
    [JsonConstructor]
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