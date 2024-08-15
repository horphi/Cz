using Xunit;

namespace Cz.EntityFrameworkCore;

[CollectionDefinition(CzTestConsts.CollectionDefinitionName)]
public class CzEntityFrameworkCoreCollection : ICollectionFixture<CzEntityFrameworkCoreFixture>
{

}
