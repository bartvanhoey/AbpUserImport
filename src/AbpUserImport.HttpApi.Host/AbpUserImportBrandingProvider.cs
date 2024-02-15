using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpUserImport
{
    [Dependency(ReplaceServices = true)]
    public class AbpUserImportBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AbpUserImport";
    }
}
