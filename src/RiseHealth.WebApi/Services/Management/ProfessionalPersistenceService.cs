using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using RiseHealth.WebApi.DTOs.Management;
using RiseHealthCare.Domain.Management;
using RiseHealthCare.Infrastructure.Data.Repositories.Management;

namespace RiseHealth.WebApi.Services.Management
{
    public class ProfessionalPersistenceService : IProfessionalPersistenceService
    {
        private readonly IMapper _mapper;
        private readonly IProfessionalRepository _repository;

        public ProfessionalPersistenceService(IMapper mapper, IProfessionalRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        
        
        public async Task<bool> SaveProfessional(ProfessionalDTO professionalDto)
        {
             _repository.SaveProfessional(_mapper.Map<Professional>(professionalDto));
            return true;
        }

        public Task<ProfessionalDTO> GetProfessionalById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ProfessionalDTO> GetProfessionalByCode(int code)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProfessionalDTO>> GetAllProfessionals()
        {
            throw new NotImplementedException();
        }
    }
}