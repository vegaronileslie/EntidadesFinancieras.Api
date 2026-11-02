using EntidadesFinancieras.Domain.DTOs;
using EntidadesFinancieras.Domain.Entities;
using EntidadesFinancieras.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EntidadesFinancieras.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinancialEntitiesController : ControllerBase
    {
        private readonly IFinancialEntityRepository _repository;

        public FinancialEntitiesController(IFinancialEntityRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FinancialEntityDto>>> GetAllAsync(){
            
            var entities = await _repository.GetAllAsync();
            return Ok(entities.Select(ToDto));

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FinancialEntityDto>> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if(entity is null) return NotFound();
            return Ok(ToDto(entity));
        }

        private static FinancialEntityDto ToDto(FinancialEntity e) => new()
        {
            Id = e.Id,
            Name = e.Name,
            Website = e.Website,
            ClassificationTypeId = e.ClassificationTypeId,
            ClassificationTypeName = e.ClassificationType.Name
        };
    }
}
