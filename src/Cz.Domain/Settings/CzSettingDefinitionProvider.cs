using Volo.Abp.Settings;

namespace Cz.Settings;

public class CzSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CzSettings.MySetting1));
    }
}
