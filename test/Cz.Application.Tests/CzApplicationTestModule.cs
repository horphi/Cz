using Volo.Abp.Modularity;

namespace Cz;

[DependsOn(
    typeof(CzApplicationModule),
    typeof(CzDomainTestModule)
)]
public class CzApplicationTestModule : AbpModule
{

}
