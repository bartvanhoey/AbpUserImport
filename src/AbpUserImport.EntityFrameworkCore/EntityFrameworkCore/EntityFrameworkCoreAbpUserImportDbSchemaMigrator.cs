using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpUserImport.Data;
using Volo.Abp.DependencyInjection;

namespace AbpUserImport.EntityFrameworkCore
{
    public class EntityFrameworkCoreAbpUserImportDbSchemaMigrator
        : IAbpUserImportDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAbpUserImportDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AbpUserImportDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AbpUserImportDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
