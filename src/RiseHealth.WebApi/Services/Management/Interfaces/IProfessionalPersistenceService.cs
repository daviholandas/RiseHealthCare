using RiseHealth.WebApi.DTOs.Management;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RiseHealth.WebApi.ViewModels.Management;

namespace RiseHealth.WebApi.Services.Management
{
    public interface IProfessionalPersistenceService
    {
        Task<bool> SaveProfessional(ProfessionalDto professionalDto);

        Task<ProfessionalViewModel> GetProfessionalById(Guid id);
        Task<ProfessionalViewModel> GetFullInfoProfessional(Guid id);
        Task<ProfessionalViewModel> GetProfessionalByCode(int code);
        Task<IEnumerable<ProfessionalBasicViewModel>> GetAllProfessionals();
    }
}