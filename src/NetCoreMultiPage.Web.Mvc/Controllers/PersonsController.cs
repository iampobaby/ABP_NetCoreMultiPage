using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreMultiPage.Controllers;

namespace NetCoreMultiPage.Web.Mvc.Controllers
{
    public class PersonsController : NetCoreMultiPageControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}