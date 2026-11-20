using Volo.Abp.Modularity;

namespace Nkust.InspectPlan;

[DependsOn(
    typeof(InspectPlanDomainModule),
    typeof(InspectPlanTestBaseModule)
)]
public class InspectPlanDomainTestModule : AbpModule
{

}
