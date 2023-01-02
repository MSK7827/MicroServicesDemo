using InstitutionApi.Model;
using InstitutionApi.Repository.InterFaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Net;

namespace InstitutionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstitutionController : ControllerBase
    {
        private readonly IInstitutionRepository _repository;
        public InstitutionController(IInstitutionRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public void Get()
        {
            var result = _repository.GetAll();
            if (result == null)
            {
                throw new Exception("no records");
            }
        }

        [HttpGet]
        public void GetByid(string id)
        {
            var result = _repository.GetById(id);
            if (result == null)
            {
                throw new Exception("not found");
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public void Create([FromBody] InstitutionModel  model )
        {
            var result = _repository.Create(model);
        }

        [HttpPut]
        public void Update(InstitutionModel model)
        {
             _repository.Update(model);
        }

        [HttpDelete]
        public void Delete(InstitutionModel id)
        {
            _repository.Delete(id);
        }
    }
}
