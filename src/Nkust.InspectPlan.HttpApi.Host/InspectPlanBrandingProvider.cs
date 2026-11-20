using Microsoft.Extensions.Localization;
using Nkust.InspectPlan.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Nkust.InspectPlan;

[Dependency(ReplaceServices = true)]
public class InspectPlanBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<InspectPlanResource> _localizer;

    public InspectPlanBrandingProvider(IStringLocalizer<InspectPlanResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
