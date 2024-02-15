using Volo.Abp.Modularity;

namespace AbpUserImport;

public abstract class AbpUserImportApplicationTestBase<TStartupModule> : AbpUserImportTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
