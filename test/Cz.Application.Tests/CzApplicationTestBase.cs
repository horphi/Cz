using Volo.Abp.Modularity;

namespace Cz;

public abstract class CzApplicationTestBase<TStartupModule> : CzTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
