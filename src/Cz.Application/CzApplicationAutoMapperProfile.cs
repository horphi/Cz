using AutoMapper;
using Cz.Books;

namespace Cz;

public class CzApplicationAutoMapperProfile : Profile
{
    public CzApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Book, BookDto>().ReverseMap();
        CreateMap<CreateOrUpdateBookDto, Book>().ReverseMap();
    }
}
