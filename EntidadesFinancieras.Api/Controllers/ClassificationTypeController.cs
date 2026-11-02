using EntidadesFinancieras.Domain.DTOs;
using EntidadesFinancieras.Domain.Entities;
using EntidadesFinancieras.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntidadesFinancieras.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassificationTypeController : ControllerBase
    {
        private readonly IClassificationTypeRepository _repository;
        public ClassificationTypeController(IClassificationTypeRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClassificationType>>> GetAllAsync()
        {

            var entities = await _repository.GetAllAsync();
            return Ok(entities);

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClassificationType>> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity is null) return NotFound();
            return Ok(entity);
        }
    }
}
