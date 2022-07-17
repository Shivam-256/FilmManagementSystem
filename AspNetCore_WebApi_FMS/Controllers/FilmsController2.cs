using AspNetCore_WebApi_FMS.Data;
using AspNetCore_WebApi_FMS.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace AspNetCore_WebApi_FMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
 //  [Authorize(Roles = "User")]
    public class FilmsController2 : ControllerBase
    {
        private IFilm2 _repository;
        public FilmsController2(IFilm2 repository)
        {
            this._repository = repository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var fmList = _repository.GetFilms();
            return Ok(fmList);
        }
        [HttpGet]
        [Route("{title}")]
        public IActionResult Get(string title)
        {
            IEnumerable<Film> fmList = _repository.SearchFilm(title);
            if (fmList != null)
            {
                return Ok(fmList);
            }
            else
            {
                return NotFound();
            }
        }
    }
}