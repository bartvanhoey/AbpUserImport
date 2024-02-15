using AbpUserImport.Localization;
using Volo.Abp.AspNetCore.Components;

namespace AbpUserImport.Blazor;

public abstract class AbpUserImportComponentBase : AbpComponentBase
{
    protected AbpUserImportComponentBase()
    {
        LocalizationResource = typeof(AbpUserImportResource);
    }
}
