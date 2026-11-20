using Volo.Abp.Modularity;

namespace Nkust.InspectPlan;

[DependsOn(
    typeof(InspectPlanApplicationModule),
    typeof(InspectPlanDomainTestModule)
)]
public class InspectPlanApplicationTestModule : AbpModule
{

}
