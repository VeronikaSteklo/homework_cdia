namespace Task18_19.DataAccessLayer.Entities;

public abstract class Publication
{
    public string Title { get; set; }
    public string Author { get; set; }

    protected Publication(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public abstract override string ToString();

    public abstract bool IsMatch(string author);

    public int CompareTo(Publication other)
    {
        return string.Compare(Author.Split(' ')[0], other.Author.Split(' ')[0], StringComparison.OrdinalIgnoreCase);
    }    
}