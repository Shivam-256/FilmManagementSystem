using AspNetCore_WebApi_FMS.Data;
using AspNetCore_WebApi_FMS.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace AspNetCore_WebApi_FMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Users")]
    public class CategoriesController2 : ControllerBase
    {
        private ICategory2 _repository;
        public CategoriesController2(ICategory2 repository)
        {
            this._repository = repository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var cgyList = _repository.GetCategories();
            return Ok(cgyList);
        }
    }
}