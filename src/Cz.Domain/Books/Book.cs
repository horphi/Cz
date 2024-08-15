using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Cz.Books
{
    public class Book : FullAuditedAggregateRoot<Guid>, IMultiTenant
    {
        public string Name { get; set; }
        public AvailableBookType BookType { get; set; }
        public DateTime PublishDate { get; set; }
        public float Price { get; set; }
        public Guid? TenantId { get; set; }
    }
}
