using Task18_19.DataAccessLayer.Entities;
using Task18_19.DataAccessLayer.DataTransferObjects;
using AutoMapper;

namespace Task18_19.DataAccessLayer.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Book, BookDTO>().ReverseMap();
        CreateMap<Article, ArticleDTO>().ReverseMap();
        CreateMap<EResource, EResourceDTO>().ReverseMap();
    }
}