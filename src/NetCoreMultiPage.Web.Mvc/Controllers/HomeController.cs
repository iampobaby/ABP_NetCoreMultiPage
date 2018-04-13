using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using NetCoreMultiPage.Controllers;

namespace NetCoreMultiPage.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : NetCoreMultiPageControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
