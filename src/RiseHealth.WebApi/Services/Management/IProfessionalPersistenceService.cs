using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RiseHealth.WebApi.DTOs.Management;

namespace RiseHealth.WebApi.Services.Management
{
    public interface IProfessionalPersistenceService
    {
        Task<bool> SaveProfessional(ProfessionalDTO professionalDto);

        Task<ProfessionalDTO> GetProfessionalById(Guid id);
        Task<ProfessionalDTO> GetProfessionalByCode(int code);
        Task<IEnumerable<ProfessionalDTO>> GetAllProfessionals();
    }
}