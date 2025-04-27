using Task18_19.DataAccessLayer.Entities;
using Task18_19.DataAccessLayer.Entities.Enum;

namespace Task18_19.Service.Interfaces;

public interface IPublicationService
{
    void AddPublication(PublicationType type, string title, string author, params string[] additionalInfo);
    void EditPublication(int index, PublicationType type, string title, string author, params string[] additionalInfo);
    void DeletePublication(int index);
    List<Publication> GetAll();
    List<Publication> SearchByAuthor(string author);
}