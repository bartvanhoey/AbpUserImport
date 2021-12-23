using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace AbpUserImport.Application.Contracts.ImportUsers
{
    public interface IImportUserAppService
    {
        Task CreateManyAsync(CreateImportUserDto input);
    }

    public class CreateImportUserDto
    {
        public List<ImportUserDto> Items { get; set; }
        public Guid? TenantId { get; set; }
    }

    public class ImportUserDto
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string UserName { get; set; }
        
        // Make sure you use a hashed password here
        [Required] public string Password { get; set; } 

        public Guid ImportUserId { get; set; }
    }
}
