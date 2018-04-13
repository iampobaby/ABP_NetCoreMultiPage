using Abp.Application.Services;
using Abp.Application.Services.Dto;
using NetCoreMultiPage.MultiTenancy.Dto;

namespace NetCoreMultiPage.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
