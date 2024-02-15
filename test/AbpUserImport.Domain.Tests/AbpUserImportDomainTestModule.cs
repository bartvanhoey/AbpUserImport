using AbpUserImport.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpUserImport
{
    [DependsOn(
        typeof(AbpUserImportEntityFrameworkCoreTestModule)
        )]
    public class AbpUserImportDomainTestModule : AbpModule
    {

    }
}