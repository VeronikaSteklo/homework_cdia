using Task18_19.DataAccessLayer.Entities;
using Task18_19.Repository.Interfaces;
using Newtonsoft.Json;


namespace Task18_19.Repository;

public class PublicationRepository : IPublicationRepository
{
    private readonly string _filePath = "C:\\Users\\veron\\RiderProjects\\Task18-19\\Task18-19\\Repository\\Files\\publications.json";
    
    private readonly JsonSerializerSettings _jsonSettings = new()
    {
        TypeNameHandling = TypeNameHandling.All,
        Formatting = Formatting.Indented
    };
    
    public List<Publication> Load()
    {
        if (!File.Exists(_filePath))
            return new List<Publication>();

        string json = File.ReadAllText(_filePath);
        return JsonConvert.DeserializeObject<List<Publication>>(json, _jsonSettings) ?? new List<Publication>();
    }

    public void Save(List<Publication> publications)
    {
        string json = JsonConvert.SerializeObject(publications, _jsonSettings);
        File.WriteAllText(_filePath, json);
    }
}