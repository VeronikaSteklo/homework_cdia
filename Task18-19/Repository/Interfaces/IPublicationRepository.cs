using Task18_19.DataAccessLayer.Entities;

namespace Task18_19.Repository.Interfaces;

public interface IPublicationRepository
{
    List<Publication> Load();
    void Save(List<Publication> publications);
}