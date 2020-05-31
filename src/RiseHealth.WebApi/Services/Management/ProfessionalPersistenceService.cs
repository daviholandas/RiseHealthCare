using AutoMapper;
using RiseHealth.WebApi.DTOs.Management;
using RiseHealthCare.Domain.Management;
using RiseHealthCare.Infrastructure.Data.Repositories.Management;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        public async Task<bool> SaveProfessional(ProfessionalDto professionalDto)
        {
            _repository.SaveProfessional(_mapper.Map<Professional>(professionalDto));
            return true;
        }

        public Task<ProfessionalDto> GetProfessionalById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ProfessionalDto> GetProfessionalByCode(int code)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProfessionalDto>> GetAllProfessionals()
        {
            throw new NotImplementedException();
        }
    }
}