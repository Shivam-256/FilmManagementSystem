using AspNetCore_WebApi_FMS.Data;
using AspNetCore_WebApi_FMS.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_WebApi_FMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : ControllerBase
    {
        private ILanguage _repository;
        public LanguagesController(ILanguage repository)
        {
            this._repository = repository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var lngList = _repository.GetLanguages();
            return Ok(lngList);
        }

        [HttpGet]
        [Route("{languageId}")]
        public IActionResult Get(int languageId)
        {
            Language obj = _repository.SearchLanguage(languageId);
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
        public IActionResult Post(Language lng)
        {
            Language ca = _repository.AddLanguage(lng);
            return CreatedAtAction("get", new { Id = ca.LanguageId }, ca);
        }

        [HttpDelete]
        public IActionResult Delete(int languageId)
        {
            bool result = _repository.DeleteLanguage(languageId);
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
        public IActionResult Put(int languageId, [FromBody] Language lng)
        {
            _repository.UpdateLanguage(languageId, lng);
            return Ok();
        }

    }
}
