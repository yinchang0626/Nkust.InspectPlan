using Xunit;

namespace Nkust.InspectPlan.EntityFrameworkCore;

[CollectionDefinition(InspectPlanTestConsts.CollectionDefinitionName)]
public class InspectPlanEntityFrameworkCoreCollection : ICollectionFixture<InspectPlanEntityFrameworkCoreFixture>
{

}
