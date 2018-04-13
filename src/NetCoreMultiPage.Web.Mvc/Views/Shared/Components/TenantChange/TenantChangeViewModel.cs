using Abp.AutoMapper;
using NetCoreMultiPage.Sessions.Dto;

namespace NetCoreMultiPage.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
