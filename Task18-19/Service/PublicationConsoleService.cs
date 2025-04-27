using Task18_19.DataAccessLayer.Entities.Enum;
using Task18_19.Service.Interfaces;

namespace Task18_19.Presentation.Service;

public class PublicationConsoleService
{
    private readonly IPublicationService _service;

    public PublicationConsoleService(IPublicationService service)
    { 
        _service = service;
    }

    public void AddPublication()
    {
        if (!TryReadPublicationData(out var type, out var title, out var author, out var additionalInfo))
            return;

        try
        {
            _service.AddPublication(type, title, author, additionalInfo);
            Console.WriteLine("Публикация успешно добавлена.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при добавлении публикации: {ex.Message}");
        }
    }

    public void EditPublication()
    {
        var all = _service.GetAll();
        if (all.Count == 0)
        {
            Console.WriteLine("Каталог пуст. Нет что редактировать.");
            return;
        }

        ShowAllPublications();

        Console.Write("Введите индекс публикации для редактирования: ");
        if (!int.TryParse(Console.ReadLine(), out int index) || index < 0 || index >= all.Count)
        {
            Console.WriteLine("Неверный индекс.");
            return;
        }

        if (!TryReadPublicationData(out var type, out var title, out var author, out var additionalInfo))
            return;

        try
        {
            _service.EditPublication(index, type, title, author, additionalInfo);
            Console.WriteLine("Публикация успешно отредактирована.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при редактировании публикации: {ex.Message}");
        }
    }

    public void DeletePublication()
    {
        var all = _service.GetAll();
        if (all.Count == 0)
        {
            Console.WriteLine("Каталог пуст. Нет что удалять.");
            return;
        }

        ShowAllPublications();

        Console.Write("Введите индекс публикации для удаления: ");
        if (!int.TryParse(Console.ReadLine(), out int index) || index < 0 || index >= all.Count)
        {
            Console.WriteLine("Неверный индекс.");
            return;
        }

        _service.DeletePublication(index);
        Console.WriteLine("Публикация удалена.");
    }

    public void ShowAllPublications()
    {
        var all = _service.GetAll();
        if (all.Count == 0)
        {
            Console.WriteLine("Каталог пуст.");
            return;
        }

        Console.WriteLine("\nКаталог публикаций:");
        for (int i = 0; i < all.Count; i++)
        {
            Console.WriteLine($"[{i}] {all[i]}");
        }
    }

    public void SearchByAuthor()
    {
        Console.Write("Введите фамилию автора для поиска: ");
        string author = Console.ReadLine();

        var found = _service.SearchByAuthor(author);

        if (found.Count == 0)
            Console.WriteLine("Публикации не найдены.");
        else
        {
            Console.WriteLine("\nНайденные публикации:");
            foreach (var pub in found)
            {
                Console.WriteLine(pub);
            }
        }
    }

    private bool TryReadPublicationData(out PublicationType type, out string title, out string author, out string[] additionalInfo)
    {
        type = PublicationType.Book;
        title = string.Empty;
        author = string.Empty;
        additionalInfo = Array.Empty<string>();

        Console.Write("Введите тип издания (Book, Article, EResource): ");
        string typeInput = Console.ReadLine()?.Trim() ?? "";

        if (!Enum.TryParse<PublicationType>(typeInput, true, out type))
        {
            Console.WriteLine("Неверный тип издания.");
            return false;
        }

        Console.Write("Введите название: ");
        title = Console.ReadLine() ?? "";

        Console.Write("Введите автора: ");
        author = Console.ReadLine() ?? "";

        switch (type)
        {
            case PublicationType.Book:
                Console.Write("Введите год издания: ");
                string yearStr = Console.ReadLine() ?? "";
                if (!int.TryParse(yearStr, out int year))
                {
                    Console.WriteLine("Неверный формат года.");
                    return false;
                }

                Console.Write("Введите издательство: ");
                string publisher = Console.ReadLine() ?? "";
                additionalInfo = new string[] { year.ToString(), publisher };
                break;

            case PublicationType.Article:
                Console.Write("Введите название журнала: ");
                string journal = Console.ReadLine() ?? "";

                Console.Write("Введите номер выпуска: ");
                string issueStr = Console.ReadLine() ?? "";
                if (!int.TryParse(issueStr, out int issue))
                {
                    Console.WriteLine("Неверный формат номера выпуска.");
                    return false;
                }

                Console.Write("Введите год издания: ");
                string yearArticleStr = Console.ReadLine() ?? "";
                if (!int.TryParse(yearArticleStr, out int yearArticle))
                {
                    Console.WriteLine("Неверный формат года.");
                    return false;
                }

                additionalInfo = new string[] { journal, issue.ToString(), yearArticle.ToString() };
                break;

            case PublicationType.EResource:
                Console.Write("Введите ссылку: ");
                string link = Console.ReadLine() ?? "";

                Console.Write("Введите аннотацию: ");
                string annotation = Console.ReadLine() ?? "";

                additionalInfo = new string[] { link, annotation };
                break;
        }

        return true;
    }
}