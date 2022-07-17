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
   // [Authorize(Roles = "Admin")]
    public class FilmsController : ControllerBase
    {
        private IFilm _repository;
        public FilmsController(IFilm repository)
        {
            this._repository = repository;
        }
        [HttpGet]
        //[AllowAnonymous]
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

        [HttpPost]
        public IActionResult Post(Film fm)
        {
            Film cf = _repository.AddFilm(fm);
            return CreatedAtAction("get", new { Id = cf.FilmId }, cf);      
        }

        [HttpDelete]
        [Route("{filmId}")]

        public IActionResult Delete(int filmId)
        {
            bool result = _repository.DeleteFilm(filmId);
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
        [Route("{filmId}")]
        public IActionResult Put(int filmId, [FromBody] Film fm)
        {
            _repository.UpdateFilm(filmId, fm);
            return Ok();
        }

    }
    }

