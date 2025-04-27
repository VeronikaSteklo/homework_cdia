using Newtonsoft.Json;

namespace Task18_19.DataAccessLayer.Entities;


public class EResource : Publication
{
    public string Link { get; set; }
    public string Annotation { get; set; }
    [JsonConstructor]
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