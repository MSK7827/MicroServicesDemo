using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SorApi.Model;
using SorApi.Repo.Interface;
using System.Net;

namespace SorApi.Controllers
{
    [Route("api/v1/institutions/{InstitutionId}/environments/{EnvironmentId}/products/{ProductId}/sors")]
    [ApiController]
    public class SorController : ControllerBase
    {
        private readonly ISorRepo _sorRepo;
        public SorController(ISorRepo sorRepo)
        {
            _sorRepo = sorRepo;
        }

        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
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
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(SorModel), (int)HttpStatusCode.OK)]
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
        public async Task<IActionResult> Delte(string id, SorModel model)
        {
            var data = await _sorRepo.GetById(id);
            if (data == null)
            {
                throw new Exception("not found");
            }
            var result = await _sorRepo.Delete(model);
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
