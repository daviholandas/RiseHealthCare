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

namespace RiseHealth.WebApi.Setup.AutoMapper
{
    public class DtoProfile : Profile
    {
        public DtoProfile()
        {
            //Management
            CreateMap<ProfessionalDto, Professional>();
            CreateMap<CouncilDto, Council>().ReverseMap();
            CreateMap<PhoneDto, Phone>().ReverseMap();
            CreateMap<ProcedureDto, Procedure>();
        }
    }
}
