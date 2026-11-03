using AutoMapper;
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
        private readonly IMapper _mapper;

        public FinancialEntitiesController(IFinancialEntityRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FinancialEntityDto>>> GetAllAsync(){
            
            var entities = await _repository.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<FinancialEntityDto>>(entities));

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FinancialEntityDto>> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if(entity is null) return NotFound();
            return Ok(_mapper.Map<FinancialEntityDto>(entity));
        }
    }
}
