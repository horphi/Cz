using Volo.Abp.Modularity;

namespace Cz;

/* Inherit from this class for your domain layer tests. */
public abstract class CzDomainTestBase<TStartupModule> : CzTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
