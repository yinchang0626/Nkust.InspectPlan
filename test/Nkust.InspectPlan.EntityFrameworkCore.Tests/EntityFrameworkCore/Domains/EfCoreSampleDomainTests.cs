using Nkust.InspectPlan.Samples;
using Xunit;

namespace Nkust.InspectPlan.EntityFrameworkCore.Domains;

[Collection(InspectPlanTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<InspectPlanEntityFrameworkCoreTestModule>
{

}
