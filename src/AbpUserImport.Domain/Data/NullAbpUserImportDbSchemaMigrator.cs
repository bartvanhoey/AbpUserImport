using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpUserImport.Data
{
    /* This is used if database provider does't define
     * IAbpUserImportDbSchemaMigrator implementation.
     */
    public class NullAbpUserImportDbSchemaMigrator : IAbpUserImportDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}