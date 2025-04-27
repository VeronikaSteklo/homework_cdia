using Task18_19.DataAccessLayer.Entities;
using Task18_19.DataAccessLayer.Entities.Enum;
using Task18_19.Repository.Interfaces;
using Task18_19.Service.Interfaces;

namespace Task18_19.Service;

public class PublicationService : IPublicationService
{
    private readonly IPublicationRepository _repository;
    private List<Publication> _catalog;

    public PublicationService(IPublicationRepository repository)
    {
        _repository = repository;
        _catalog = _repository.Load();
    }

    public void AddPublication(PublicationType type, string title, string author, params string[] additionalInfo)
    {
        Publication publication = type switch
        {
            PublicationType.Book => new Book(title, author, int.Parse(additionalInfo[0]), additionalInfo[1]),
            PublicationType.Article => new Article(title, author, additionalInfo[0], int.Parse(additionalInfo[1]), int.Parse(additionalInfo[2])),
            PublicationType.EResource => new EResource(title, author, additionalInfo[0], additionalInfo[1]),
            _ => throw new ArgumentException("Неверный тип публикации")
        };

        _catalog.Add(publication);
        _repository.Save(_catalog);
    }

    public void EditPublication(int index, PublicationType type, string title, string author, params string[] additionalInfo)
    {
        if (index < 0 || index >= _catalog.Count)
        {
            Console.WriteLine("Некорректный индекс публикации для редактирования.");
            return;
        }

        Publication updated = type switch
        {
            PublicationType.Book => new Book(title, author, int.Parse(additionalInfo[0]), additionalInfo[1]),
            PublicationType.Article => new Article(title, author, additionalInfo[0], int.Parse(additionalInfo[1]), int.Parse(additionalInfo[2])),
            PublicationType.EResource => new EResource(title, author, additionalInfo[0], additionalInfo[1]),
            _ => throw new ArgumentException("Неверный тип публикации")
        };

        _catalog[index] = updated;
        _repository.Save(_catalog);
    }

    public void DeletePublication(int index)
    {
        if (index < 0 || index >= _catalog.Count)
        {
            Console.WriteLine("Некорректный индекс публикации для удаления.");
            return;
        }

        _catalog.RemoveAt(index);
        _repository.Save(_catalog);
    }

    public List<Publication> GetAll()
    {
        return _catalog;
    }

    public List<Publication> SearchByAuthor(string author)
    {
        return _catalog.FindAll(p => p.IsMatch(author));
    }
}