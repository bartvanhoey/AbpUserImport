using System.Threading.Tasks;

namespace AbpUserImport.Data
{
    public interface IAbpUserImportDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
