using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Nkust.InspectPlan.Data;

/* This is used if database provider does't define
 * IInspectPlanDbSchemaMigrator implementation.
 */
public class NullInspectPlanDbSchemaMigrator : IInspectPlanDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
