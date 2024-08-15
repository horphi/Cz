using Cz.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Cz.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CzEntityFrameworkCoreModule),
    typeof(CzApplicationContractsModule)
    )]
public class CzDbMigratorModule : AbpModule
{
}
