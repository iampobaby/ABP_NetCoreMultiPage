using System.Threading.Tasks;
using Abp.Application.Services;
using NetCoreMultiPage.Sessions.Dto;

namespace NetCoreMultiPage.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
