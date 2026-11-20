using System.Threading.Tasks;

namespace Nkust.InspectPlan.Data;

public interface IInspectPlanDbSchemaMigrator
{
    Task MigrateAsync();
}
