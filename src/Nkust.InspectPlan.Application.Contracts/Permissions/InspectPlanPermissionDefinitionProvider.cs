using Nkust.InspectPlan.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Nkust.InspectPlan.Permissions;

public class InspectPlanPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(InspectPlanPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(InspectPlanPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<InspectPlanResource>(name);
    }
}
