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
    public class ActorsController : ControllerBase
    {
        private IActor _repository;
        public ActorsController(IActor repository)
        {
            this._repository = repository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var actList = _repository.GetActors();
            return Ok(actList);
        }

        [HttpGet]
        [Route("{actorId}")]
        public IActionResult Get(int actorId)
        {
            Actor obj = _repository.SearchActor(actorId);
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
        public IActionResult Post(Actor act)
        {
            Actor ca = _repository.AddActor(act);
            return CreatedAtAction("get", new { Id = ca.ActorId }, ca);
        }



        [HttpDelete]
        [Route("{actorId}")]
        public IActionResult Delete(int actorId)
        {
            bool result = _repository.DeleteActor(actorId);
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
        [Route("{actorId}")]
        public IActionResult Put(int actorId, [FromBody] Actor act)
        {
            _repository.UpdateActor(actorId, act);
            return Ok();
        }



    }
}