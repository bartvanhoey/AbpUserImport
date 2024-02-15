using AbpUserImport.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpUserImport.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpUserImportEntityFrameworkCoreModule),
        typeof(AbpUserImportApplicationContractsModule)
        )]
    public class AbpUserImportDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
