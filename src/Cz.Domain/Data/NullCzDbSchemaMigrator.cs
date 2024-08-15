using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Cz.Data;

/* This is used if database provider does't define
 * ICzDbSchemaMigrator implementation.
 */
public class NullCzDbSchemaMigrator : ICzDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
