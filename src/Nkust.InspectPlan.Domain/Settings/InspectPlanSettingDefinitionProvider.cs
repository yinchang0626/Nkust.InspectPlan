using Volo.Abp.Settings;

namespace Nkust.InspectPlan.Settings;

public class InspectPlanSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(InspectPlanSettings.MySetting1));
    }
}
