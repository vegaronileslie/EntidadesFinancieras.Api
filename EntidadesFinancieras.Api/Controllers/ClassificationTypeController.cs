using AutoMapper;
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
        private readonly IMapper _mapper;
        public ClassificationTypeController(IClassificationTypeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClassificationTypeDto>>> GetAllAsync()
        {

            var entities = await _repository.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<ClassificationTypeDto>>(entities));

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClassificationTypeDto>> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity is null) return NotFound();
            return Ok(_mapper.Map<ClassificationTypeDto>(entity));
        }
    }
}
