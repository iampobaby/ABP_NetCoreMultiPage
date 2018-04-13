﻿using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace NetCoreMultiPage.Web.Views
{
    public abstract class NetCoreMultiPageRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected NetCoreMultiPageRazorPage()
        {
            LocalizationSourceName = NetCoreMultiPageConsts.LocalizationSourceName;
        }
    }
}
