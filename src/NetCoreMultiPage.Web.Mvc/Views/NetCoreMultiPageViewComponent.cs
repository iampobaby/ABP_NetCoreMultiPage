using Abp.AspNetCore.Mvc.ViewComponents;

namespace NetCoreMultiPage.Web.Views
{
    public abstract class NetCoreMultiPageViewComponent : AbpViewComponent
    {
        protected NetCoreMultiPageViewComponent()
        {
            LocalizationSourceName = NetCoreMultiPageConsts.LocalizationSourceName;
        }
    }
}
