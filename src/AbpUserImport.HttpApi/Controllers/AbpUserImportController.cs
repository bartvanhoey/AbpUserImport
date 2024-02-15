using AbpUserImport.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpUserImport.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpUserImportController : AbpControllerBase
{
    protected AbpUserImportController()
    {
        LocalizationResource = typeof(AbpUserImportResource);
    }
}
