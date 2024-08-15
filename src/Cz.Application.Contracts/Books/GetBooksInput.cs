using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Cz.Books
{
    public class GetBooksInput : PagedAndSortedResultRequestDto
    {
        public string? Filter { get; set; }
        public Guid? TenantId { get; set; }
    }
}
