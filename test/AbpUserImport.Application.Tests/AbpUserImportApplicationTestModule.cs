using Volo.Abp.Modularity;

namespace AbpUserImport;

[DependsOn(
    typeof(AbpUserImportApplicationModule),
    typeof(AbpUserImportDomainTestModule)
)]
public class AbpUserImportApplicationTestModule : AbpModule
{

}
