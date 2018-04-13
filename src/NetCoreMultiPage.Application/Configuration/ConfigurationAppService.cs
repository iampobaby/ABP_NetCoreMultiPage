using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using NetCoreMultiPage.Configuration.Dto;

namespace NetCoreMultiPage.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : NetCoreMultiPageAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
