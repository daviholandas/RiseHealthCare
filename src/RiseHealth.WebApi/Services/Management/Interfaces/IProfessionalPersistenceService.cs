using RiseHealth.WebApi.DTOs.Management;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RiseHealth.WebApi.Services.Management
{
    public interface IProfessionalPersistenceService
    {
        Task<bool> SaveProfessional(ProfessionalDto professionalDto);

        Task<ProfessionalDto> GetProfessionalById(Guid id);

        Task<ProfessionalDto> GetProfessionalByCode(int code);

        Task<IEnumerable<ProfessionalDto>> GetAllProfessionals();
    }
}