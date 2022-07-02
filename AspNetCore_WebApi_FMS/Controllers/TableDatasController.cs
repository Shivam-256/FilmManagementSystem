using AspNetCore_WebApi_FMS.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_WebApi_FMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableDatasController : ControllerBase
    {
        private ITableData _repository;
        public TableDatasController(ITableData repository)
        {
            this._repository = repository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var tbList = _repository.GetTableDatas();
            return Ok(tbList);
        }
    }
}
