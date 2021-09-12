using Volo.Abp.Settings;

namespace Adrash.Settings
{
    public class AdrashSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AdrashSettings.MySetting1));
        }
    }
}
