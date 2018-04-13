using System.Threading.Tasks;
using NetCoreMultiPage.Configuration.Dto;

namespace NetCoreMultiPage.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
