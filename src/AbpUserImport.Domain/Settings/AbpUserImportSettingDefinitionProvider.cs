using Volo.Abp.Settings;

namespace AbpUserImport.Settings
{
    public class AbpUserImportSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AbpUserImportSettings.MySetting1));
        }
    }
}
