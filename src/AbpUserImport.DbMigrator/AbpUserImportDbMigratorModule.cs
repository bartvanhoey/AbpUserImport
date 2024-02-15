using AbpUserImport.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AbpUserImport.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpUserImportEntityFrameworkCoreModule),
    typeof(AbpUserImportApplicationContractsModule)
    )]
public class AbpUserImportDbMigratorModule : AbpModule
{
}
