using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Volo.Abp.Data;
using Volo.Abp.Guids;
using Volo.Abp.Identity;

namespace AbpUserImport.ImportUsers
{
    public class ImportUserAppService(IGuidGenerator guidGenerator, IdentityUserManager identityUserManager)
        : AbpUserImportAppService, IImportUserAppService
    {
        public async Task CreateManyAsync(CreateImportUserDto input)
        {
            using (CurrentTenant.Change(input.TenantId))
            {
                SetIdentityOptions();
                foreach (var item in input.Items)
                {
                    await InsertImportUserInDatabaseAsync(item, input.TenantId);
                }
            }
        }

        // You will probably need to adapt this method to your needs
        private void SetIdentityOptions()
        {
            identityUserManager.Options.User.RequireUniqueEmail = true;
            identityUserManager.Options.User.AllowedUserNameCharacters = $"{identityUserManager.Options.User.AllowedUserNameCharacters}"; // add special characters here!
            identityUserManager.Options.Password.RequireDigit = false;
            identityUserManager.Options.Password.RequireUppercase = false;
            identityUserManager.Options.Password.RequireNonAlphanumeric = false;
            identityUserManager.Options.Password.RequireLowercase = false;
            identityUserManager.Options.Password.RequiredLength = 1;
        }

        private async Task InsertImportUserInDatabaseAsync(ImportUserDto user, Guid? tenantId)
        {
            var identityUser = new IdentityUser(guidGenerator.Create(), user.Email, user.Email, tenantId);
            identityUser.SetProperty("ImportUserId", user.ImportUserId.ToString());
            var createdUser = await identityUserManager.CreateAsync(identityUser, user.Password, true);
            createdUser.CheckErrors();
        }
    }
}