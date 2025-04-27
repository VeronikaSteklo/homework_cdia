using Task18_19.DataAccessLayer.Entities.Enum;
using Task18_19.Presentation.Service;
using Task18_19.Repository;
using Task18_19.Service;
using Task18_19.Service.Interfaces;

namespace Task18_19.Presentation;

public class Program
{
    static void Main()
    {
        IPublicationService service = new PublicationService(new PublicationRepository());
        var consoleService = new PublicationConsoleService(service);

        while (true)
        {
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1. Добавить публикацию");
            Console.WriteLine("2. Редактировать публикацию");
            Console.WriteLine("3. Удалить публикацию");
            Console.WriteLine("4. Показать все публикации");
            Console.WriteLine("5. Найти публикации по автору");
            Console.WriteLine("0. Выход");

            Console.Write("Ваш выбор: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": consoleService.AddPublication(); break;
                case "2": consoleService.EditPublication(); break;
                case "3": consoleService.DeletePublication(); break;
                case "4": consoleService.ShowAllPublications(); break;
                case "5": consoleService.SearchByAuthor(); break;
                case "0": return;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }
    }
}