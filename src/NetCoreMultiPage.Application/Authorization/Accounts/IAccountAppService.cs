using System.Threading.Tasks;
using Abp.Application.Services;
using NetCoreMultiPage.Authorization.Accounts.Dto;

namespace NetCoreMultiPage.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
