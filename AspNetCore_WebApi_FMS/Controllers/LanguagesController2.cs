using AspNetCore_WebApi_FMS.Data;
using AspNetCore_WebApi_FMS.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace AspNetCore_WebApi_FMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController2 : ControllerBase
    {
        private ILanguage2 _repository;
        public LanguagesController2(ILanguage2 repository)
        {
            this._repository = repository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var lngList = _repository.GetLanguages();
            return Ok(lngList);
        }
    }
}