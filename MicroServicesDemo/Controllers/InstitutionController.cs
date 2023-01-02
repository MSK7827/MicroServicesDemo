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
}
}
