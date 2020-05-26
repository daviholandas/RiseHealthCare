using AutoMapper;
using RiseHealth.WebApi.DTOs.Common;
using RiseHealth.WebApi.DTOs.Management;
using RiseHealthCare.Domain.Management;
using RiseHealthCare.Domain.Management.ValueObjects;
using RiseHealthCare.Domain.Shared.ValueObjects;

namespace RiseHealth.WebApi.AutoMapper
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            CreateMap<Professional, ProfessionalDTO>();
            CreateMap<Procedure, ProcedureDTO>();
            CreateMap<Phone, PhoneDTO>();
            CreateMap<Council, CouncilDTO>();
        }
    }
}