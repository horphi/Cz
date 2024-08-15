using System.Threading.Tasks;

namespace Cz.Data;

public interface ICzDbSchemaMigrator
{
    Task MigrateAsync();
}
