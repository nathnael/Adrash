using Adrash.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Adrash.Permissions
{
    public class AdrashPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AdrashPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(AdrashPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AdrashResource>(name);
        }
    }
}
