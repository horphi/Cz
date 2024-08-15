using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;
using System.Linq.Dynamic.Core;
using Volo.Abp.Validation.Localization;

namespace Cz.Books
{
    public class BookAppService : CzAppService, IBookAppService
    {
        public readonly IRepository<Book, Guid> _bookRepository;

        public BookAppService(IRepository<Book, Guid> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task CreateAsync(CreateOrUpdateBookDto input)
        {
            var book = ObjectMapper.Map<CreateOrUpdateBookDto, Book>(input);
            await _bookRepository.InsertAsync(book);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _bookRepository.DeleteAsync(id);
        }

        public async Task<BookDto> GetAsync(Guid id)
        {
            var book = await _bookRepository.GetAsync(id);
            return ObjectMapper.Map<Book, BookDto>(book);
        }

        public async Task<PagedResultDto<BookDto>> GetPagedListAsync(GetBooksInput input)
        {
            var filteredQuery = (await _bookRepository.GetQueryableAsync())
                .WhereIf(!input.Filter.IsNullOrWhiteSpace(), x => x.Name.Contains(input.Filter!, StringComparison.InvariantCultureIgnoreCase));

            // Default sorting is by PublishDate in descending order
            var pagedFileredQuery = filteredQuery
                .OrderBy(input.Sorting ?? nameof(Book.PublishDate) + " DESC")
                .PageBy(input);

            var totalCount = filteredQuery.Count();
            var results = await AsyncExecuter.ToListAsync(pagedFileredQuery);

            var pagedResult = new PagedResultDto<BookDto>(totalCount, ObjectMapper.Map<List<Book>, List<BookDto>>(results));

            return pagedResult;

        }

        public async Task UpdateAsync(Guid id, CreateOrUpdateBookDto input)
        {
            var book = await _bookRepository.GetAsync(id);
            ObjectMapper.Map(input, book);
            await _bookRepository.UpdateAsync(book);
        }
    }
}
