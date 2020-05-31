using System;
using AutoMapper;
using RiseHealth.WebApi.DTOs.Common;
using RiseHealth.WebApi.DTOs.Management;
using RiseHealthCare.Domain.Management;
using RiseHealthCare.Domain.Management.ValueObjects;
using RiseHealthCare.Domain.Shared.ValueObjects;

namespace RiseHealth.WebApi.Setup
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ProfessionalDto, Professional>()
                .ReverseMap();
            CreateMap<CouncilDto, Council>().ReverseMap();
            CreateMap<PhoneDto, Phone>().ReverseMap();
            CreateMap<ProcedureDto, Procedure>().ReverseMap();
        }
    }
}