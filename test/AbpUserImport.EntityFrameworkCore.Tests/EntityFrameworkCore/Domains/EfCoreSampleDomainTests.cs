using AbpUserImport.Samples;
using Xunit;

namespace AbpUserImport.EntityFrameworkCore.Domains;

[Collection(AbpUserImportTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AbpUserImportEntityFrameworkCoreTestModule>
{

}
