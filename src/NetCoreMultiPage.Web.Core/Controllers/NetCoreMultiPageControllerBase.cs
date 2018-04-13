using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace NetCoreMultiPage.Controllers
{
    public abstract class NetCoreMultiPageControllerBase: AbpController
    {
        protected NetCoreMultiPageControllerBase()
        {
            LocalizationSourceName = NetCoreMultiPageConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
