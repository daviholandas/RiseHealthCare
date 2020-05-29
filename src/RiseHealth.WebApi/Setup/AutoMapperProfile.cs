using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            CreateMap<ProfessionalDTO, Professional>().ReverseMap();
            CreateMap<CouncilDTO, Council>().ReverseMap();
            CreateMap<PhoneDTO, Phone>().ReverseMap();
            CreateMap<ProcedureDTO, Procedure>().ReverseMap();
        }
    }
}
