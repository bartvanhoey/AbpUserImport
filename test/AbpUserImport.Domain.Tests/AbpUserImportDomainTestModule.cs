using Volo.Abp.Modularity;

namespace AbpUserImport;

[DependsOn(
    typeof(AbpUserImportDomainModule),
    typeof(AbpUserImportTestBaseModule)
)]
public class AbpUserImportDomainTestModule : AbpModule
{

}
