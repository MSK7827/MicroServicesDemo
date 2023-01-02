using EnvironMentApi.Model;
using EnvironMentApi.Repo.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EnvironMentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnvironMentController : ControllerBase
    {
        private readonly IEnvironment _environment;
        public EnvironMentController(IEnvironment environment)
        {
            _environment = environment;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _environment.GetAll();
            if(result == null)
            {
                throw new Exception("no record found");
            }

            return Ok(result);
        }

        [HttpGet("{Id}")]
        public IActionResult Get(string id)
        {
            var result = _environment.GetById(id);
            if (result == null)
            {
                throw new Exception("no record found");
            }

            return Ok(result);
        }

        [HttpDelete]
        public IActionResult Delte(string id)
        {
            var data = _environment.GetById(id);
            if (data == null)
            {
                throw new Exception("not found");
            }
            var result = _environment.Delete(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post([FromBody] EnviornmentModel model)
        {
            var result = _environment.Create(model);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Update(string id,[FromBody] EnviornmentModel model )
        {
            var data = _environment.GetById(id);
            if (data == null)
            {
                throw new Exception("not found");
            }
            var result = _environment.Update(id,model);
            return Ok(result);
        }
    }
}
