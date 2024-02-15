using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace AbpUserImport.ImportUsers
{
    public interface IImportUserAppService
    {
        Task CreateManyAsync(CreateImportUserDto input);
    }

    public class CreateImportUserDto
    {
        public List<ImportUserDto> Items { get; set; } = [];
        public Guid? TenantId { get; set; }
    }

    public class ImportUserDto
    {
        [Required, DataType(DataType.EmailAddress)] public string Email { get; set; } = "";
        [Required] public string Password { get; set; } = "";
        public Guid ImportUserId { get; set; }
    }
}