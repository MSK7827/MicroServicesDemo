using InstitutionApi.Model;
using InstitutionApi.Repository.InterFaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace InstitutionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstitutionController : ControllerBase
    {
        private readonly IRepository<InstitutionModel> _repository;
        public InstitutionController(IRepository<InstitutionModel> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<InstitutionModel> Get()
        {
            return await _repository.GetAll().ToList();
        }

        [HttpGet("{id}")]
        public async Task Get(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
                return NotFound();
            return Ok(product);

        }

        [HttpPost]
        public async Task Post(Product product)
        {
            _context.Add(product);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task Put(Product productData)
        {
            if (productData == null || productData.Id == 0)
                return BadRequest();

            var product = await _context.Products.FindAsync(productData.Id);
            if (product == null)
                return NotFound();
            product.Name = productData.Name;
            product.Description = productData.Description;
            product.Price = productData.Price;
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null) return NotFound();
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return Ok();

        }
    }
}
}
