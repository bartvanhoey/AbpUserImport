using Xunit;

namespace AbpUserImport.EntityFrameworkCore;

[CollectionDefinition(AbpUserImportTestConsts.CollectionDefinitionName)]
public class AbpUserImportEntityFrameworkCoreCollection : ICollectionFixture<AbpUserImportEntityFrameworkCoreFixture>
{

}
