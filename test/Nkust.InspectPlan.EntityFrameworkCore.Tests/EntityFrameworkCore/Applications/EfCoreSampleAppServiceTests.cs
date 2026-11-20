using Nkust.InspectPlan.Samples;
using Xunit;

namespace Nkust.InspectPlan.EntityFrameworkCore.Applications;

[Collection(InspectPlanTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<InspectPlanEntityFrameworkCoreTestModule>
{

}
