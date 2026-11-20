using Nkust.InspectPlan.Localization;
using Volo.Abp.Application.Services;

namespace Nkust.InspectPlan;

/* Inherit your application services from this class.
 */
public abstract class InspectPlanAppService : ApplicationService
{
    protected InspectPlanAppService()
    {
        LocalizationResource = typeof(InspectPlanResource);
    }
}
