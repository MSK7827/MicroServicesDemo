using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SorApi.Model;
using SorApi.Repo.Interface;

namespace SorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SorController : ControllerBase
    {
        private readonly ISorRepo _sorRepo;
        public SorController(ISorRepo sorRepo)
        {
            _sorRepo = sorRepo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _sorRepo.GetAll();
            if (result == null)
            {
                throw new Exception("no record found");
            }

            return Ok(result);
        }

        [HttpGet("{Id}")]
        public IActionResult Get(string id)
        {
            var result = _sorRepo.GetById(id);
            if (result == null)
            {
                throw new Exception("no record found");
            }

            return Ok(result);
        }

        [HttpDelete]
        public IActionResult Delte(string id, SorModel model)
        {
            var data = _sorRepo.GetById(id);
            if (data == null)
            {
                throw new Exception("not found");
            }
            var result = _sorRepo.Delete(model);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post([FromBody] SorModel model)
        {
            var result = _sorRepo.Create(model);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Update(string id, [FromBody] SorModel model)
        {
            var data = _sorRepo.GetById(id);
            if (data == null)
            {
                throw new Exception("not found");
            }
            var result = _sorRepo.Update(id, model);
            return Ok(result);
        }
    }
}
