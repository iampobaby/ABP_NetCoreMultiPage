using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;

using NetCoreMultiPage.Controllers;
using NetCoreMultiPage.PhoneBooks;
using NetCoreMultiPage.PhoneBooks.Dtos;
using NetCoreMultiPage.PhoneBooks.Persons;




namespace NetCoreMultiPage.Web.Controllers
{
    public class PersonsController : NetCoreMultiPageControllerBase
    {

        private readonly IPersonAppService _personAppService;
        

        public PersonsController(IPersonAppService personAppService)
        {
            _personAppService = personAppService;
        }

        public async Task<IActionResult> Index(GetPersonInput input)
        {
            var dtos = await _personAppService.GetPagedPersonAsync(input); 
            return View(dtos);
        }
    }
}

