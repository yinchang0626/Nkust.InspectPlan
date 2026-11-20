using Nkust.InspectPlan.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Nkust.InspectPlan.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(InspectPlanEntityFrameworkCoreModule),
    typeof(InspectPlanApplicationContractsModule)
)]
public class InspectPlanDbMigratorModule : AbpModule
{
}
