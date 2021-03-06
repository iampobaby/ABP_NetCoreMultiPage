using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using NetCoreMultiPage.Roles.Dto;
using NetCoreMultiPage.Users.Dto;

namespace NetCoreMultiPage.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
