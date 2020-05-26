using System.Collections.Generic;
using AutoMapper;
using RiseHealth.WebApi.DTOs.Common;
using RiseHealth.WebApi.DTOs.Management;
using RiseHealthCare.Domain.Management;
using RiseHealthCare.Domain.Management.ValueObjects;
using RiseHealthCare.Domain.Shared.ValueObjects;

namespace RiseHealth.WebApi.AutoMapper
{
    public class DtoToDomainMappingProfile : Profile
    {
        private readonly IMapper _mapper;

        public DtoToDomainMappingProfile(IMapper mapper)
        {
            _mapper = mapper;
        }
        public DtoToDomainMappingProfile()
        {
            CreateMap<CouncilDTO, Council>()
                .ConstructUsing(c => new Council(c.Name, c.RegistrationCode,
                    c.RegistrationIsValid, c.EndToRegistration));
            CreateMap<PhoneDTO, Phone>()
                .ConstructUsing(ph => new Phone(ph.NumberType, ph.Number, ph.IsWhatsapp));
            CreateMap<ProcedureDTO, Procedure>();
          
            CreateMap<ProfessionalDTO, Professional>()
                .ConstructUsing(p => new Professional(p.Code, p.Name, p.Photo,
                    p.HiringDate, p.FiringDate,_mapper.Map<CouncilDTO, Council>(p.Council),
                    _mapper.Map<IList<PhoneDTO>, IList<Phone>>(p.Phones), 
                    _mapper.Map<IList<ProcedureDTO>, IList<Procedure>>(p.Procedures), p.Active));
        }
    }
}