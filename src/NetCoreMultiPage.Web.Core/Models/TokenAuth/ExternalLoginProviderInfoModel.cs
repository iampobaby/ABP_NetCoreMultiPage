using Abp.AutoMapper;
using NetCoreMultiPage.Authentication.External;

namespace NetCoreMultiPage.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
