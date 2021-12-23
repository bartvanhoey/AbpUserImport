using System;
using System.Threading.Tasks;
using AbpUserImport.Application.Contracts.ImportUsers;
using Microsoft.AspNetCore.Identity;
using Volo.Abp.Data;
using Volo.Abp.Guids;
using Volo.Abp.Identity;
using IdentityUser = Volo.Abp.Identity.IdentityUser;

namespace AbpUserImport.Application.ImportUsers
{
    public class ImportUserAppService : AbpUserImportAppService, IImportUserAppService
    {
        private readonly IGuidGenerator _guidGenerator;
        private readonly IdentityUserManager _identityUserManager;

        public ImportUserAppService(IGuidGenerator guidGenerator, IdentityUserManager identityUserManager)
        {
            _guidGenerator = guidGenerator;
            _identityUserManager = identityUserManager;
        }

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

        private void SetIdentityOptions()
        {
            _identityUserManager.Options.User.RequireUniqueEmail = true;
            _identityUserManager.Options.User.AllowedUserNameCharacters = $"{_identityUserManager.Options.User.AllowedUserNameCharacters}"; // add special characters here!
            _identityUserManager.Options.Password.RequireDigit = false;
            _identityUserManager.Options.Password.RequireUppercase = false;
            _identityUserManager.Options.Password.RequireNonAlphanumeric = false;
            _identityUserManager.Options.Password.RequireLowercase = false;
            _identityUserManager.Options.Password.RequiredLength = 1;
        }

        private async Task InsertImportUserInDatabaseAsync(ImportUserDto user, Guid? tenantId)
        {
            var identityUser = new IdentityUser(_guidGenerator.Create(), user.Email, user.Email, tenantId);
            identityUser.SetProperty("ImportUserId", user.ImportUserId.ToString());
            var createdUser = await _identityUserManager.CreateAsync(identityUser, user.Password, false);
            createdUser.CheckErrors();
        }
    }
}
