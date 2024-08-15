using Cz.Samples;
using Xunit;

namespace Cz.EntityFrameworkCore.Domains;

[Collection(CzTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<CzEntityFrameworkCoreTestModule>
{

}
