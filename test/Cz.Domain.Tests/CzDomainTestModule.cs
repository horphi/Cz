using Volo.Abp.Modularity;

namespace Cz;

[DependsOn(
    typeof(CzDomainModule),
    typeof(CzTestBaseModule)
)]
public class CzDomainTestModule : AbpModule
{

}
