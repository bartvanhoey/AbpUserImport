using System;
using Volo.Abp.Identity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.Threading;

namespace AbpUserImport.EntityFrameworkCore;

public static class AbpUserImportEfCoreEntityExtensionMappings
{
    private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

    public static void Configure()
    {
        AbpUserImportGlobalFeatureConfigurator.Configure();
        AbpUserImportModuleExtensionConfigurator.Configure();

        OneTimeRunner.Run(() =>
        {
            // Other code here ...
            // This piece of code adds an extra ImportUserId property to the IdentityUser class
            ObjectExtensionManager.Instance
            .MapEfCoreProperty<IdentityUser, Guid?>(
                "ImportUserId",
                (_, propertyBuilder) =>
                {
                    propertyBuilder.HasMaxLength(36);
                }
            );
        });
    }
}
