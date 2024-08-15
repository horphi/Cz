using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Cz.Books
{
    public interface IBookAppService: IApplicationService
    {
        Task CreateAsync(CreateOrUpdateBookDto input);
        Task UpdateAsync(Guid id, CreateOrUpdateBookDto input);
        Task DeleteAsync(Guid id);  
        Task<BookDto> GetAsync(Guid id);
        Task<PagedResultDto<BookDto>> GetPagedListAsync(GetBooksInput input);
    }
}
