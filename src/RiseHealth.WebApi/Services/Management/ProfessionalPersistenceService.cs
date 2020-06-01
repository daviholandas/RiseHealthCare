using AutoMapper;
using RiseHealth.WebApi.DTOs.Management;
using RiseHealthCare.Domain.Management;
using RiseHealthCare.Infrastructure.Data.Repositories.Management;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RiseHealth.WebApi.ViewModels.Management;

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
            var result = await _repository.SaveProfessional(_mapper.Map<Professional>(professionalDto));

            if (result > 0)
                return true;
           
            return false;
        }

        public async Task<ProfessionalViewModel> GetProfessionalById(Guid id)
            =>  _mapper.Map<ProfessionalViewModel>(await _repository.GetProfessionalById(id));

        public async Task<ProfessionalViewModel> GetFullInfoProfessional(Guid id)
            => _mapper.Map<ProfessionalViewModel>(await _repository.GetProfessionalById(id));

        public async Task<ProfessionalViewModel> GetProfessionalByCode(int code)
            => _mapper.Map<ProfessionalViewModel>(await _repository.GetProfessionalByCode(code));

        public async Task<IEnumerable<ProfessionalBasicViewModel>> GetAllProfessionals()
            => _mapper.Map<IEnumerable<ProfessionalBasicViewModel>>( await _repository.GetAllProfessionals());

      
    }
}