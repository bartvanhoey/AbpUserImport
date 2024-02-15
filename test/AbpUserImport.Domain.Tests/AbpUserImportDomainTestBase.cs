using Volo.Abp.Modularity;

namespace AbpUserImport;

/* Inherit from this class for your domain layer tests. */
public abstract class AbpUserImportDomainTestBase<TStartupModule> : AbpUserImportTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
