﻿using AbpUserImport.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpUserImport.Permissions
{
    public class AbpUserImportPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AbpUserImportPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(AbpUserImportPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpUserImportResource>(name);
        }
    }
}
