using System;
using System.Collections.Generic;
using System.Text;
using AbpUserImport.Localization;
using Volo.Abp.Application.Services;

namespace AbpUserImport
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpUserImportAppService : ApplicationService
    {
        protected AbpUserImportAppService()
        {
            LocalizationResource = typeof(AbpUserImportResource);
        }
    }
}
