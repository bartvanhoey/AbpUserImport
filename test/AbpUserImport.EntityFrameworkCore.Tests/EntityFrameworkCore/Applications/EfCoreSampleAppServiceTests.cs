using AbpUserImport.Samples;
using Xunit;

namespace AbpUserImport.EntityFrameworkCore.Applications;

[Collection(AbpUserImportTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AbpUserImportEntityFrameworkCoreTestModule>
{

}
