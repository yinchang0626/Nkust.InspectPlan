using Nkust.InspectPlan.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Nkust.InspectPlan.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class InspectPlanController : AbpControllerBase
{
    protected InspectPlanController()
    {
        LocalizationResource = typeof(InspectPlanResource);
    }
}
