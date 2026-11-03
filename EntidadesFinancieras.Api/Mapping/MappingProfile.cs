using AutoMapper;
using EntidadesFinancieras.Domain.DTOs;
using EntidadesFinancieras.Domain.Entities;

namespace EntidadesFinancieras.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<FinancialEntity, FinancialEntityDto>();
            CreateMap<ClassificationType, ClassificationTypeDto>();
        }
    }
}
