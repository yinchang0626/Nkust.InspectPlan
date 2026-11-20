using Volo.Abp.Modularity;

namespace Nkust.InspectPlan;

public abstract class InspectPlanApplicationTestBase<TStartupModule> : InspectPlanTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
