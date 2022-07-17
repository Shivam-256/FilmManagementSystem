using AspNetCore_WebApi_FMS.Data;
using AspNetCore_WebApi_FMS.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_WebApi_FMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
 // [Authorize(Roles = "Admin")]
    public class CategoriesController : ControllerBase
    {
        private ICategory _repository;
        public CategoriesController(ICategory repository)
        {
            this._repository = repository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var cgyList = _repository.GetCategories();
            return Ok(cgyList);
        }

        [HttpGet]
        [Route("{categoryId}")]
        public IActionResult Get(int categoryId)
        {
            Category obj = _repository.SearchCategory(categoryId);
            if (obj != null)
            {
                return Ok(obj);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult Post(Category ct)
        {
            Category cy = _repository.AddCategory(ct);
            return CreatedAtAction("get", new { Id = cy.CategoryId }, cy);
        }

        [HttpDelete]
        [Route("{categoryId}")]
        public IActionResult Delete(int categoryId)
        {
            bool result = _repository.DeleteCategory(categoryId);
            if (result == true)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut]
        [Route("{categoryId}")]
        public IActionResult Put(int categoryId, [FromBody] Category cgy)
        {
            _repository.UpdateCategory(categoryId, cgy);
            return Ok();
        }

    }
}
