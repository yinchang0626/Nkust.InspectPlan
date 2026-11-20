using Volo.Abp.Modularity;

namespace Nkust.InspectPlan;

/* Inherit from this class for your domain layer tests. */
public abstract class InspectPlanDomainTestBase<TStartupModule> : InspectPlanTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
