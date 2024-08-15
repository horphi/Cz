using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Cz.Books
{
    public class BookSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Book,Guid> _bookRepository;

        public BookSeedContributor(IRepository<Book,Guid> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public virtual async Task SeedAsync(DataSeedContext context)
        {
            //if (await _bookRepository.GetCountAsync() <= 0)
            //{
            //    await _bookRepository.InsertAsync(
            //        new Book
            //        {
            //            Name = "1984",
            //            BookType = AvailableBookType.ScienceFiction,
            //            PublishDate = new DateTime(1949, 6, 8),
            //            Price = 19.84f
            //        },
            //        autoSave: true
            //    );

            //    await _bookRepository.InsertAsync(
            //        new Book
            //        {
            //            Name = "The Da Vinci Code",
            //            BookType = AvailableBookType.Mystery,
            //            PublishDate = new DateTime(2003, 3, 18),
            //            Price = 24.95f
            //        },
            //        autoSave: true
            //    );
            //}
        }
    }
}
