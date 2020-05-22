using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RiseHealthCare.Domain.Management;
using RiseHealthCare.Domain.Shared.DomainObjects;

namespace RiseHealthCare.Infrastructure.Data.Repositories.Management
{
    public interface IProfessionalRepository : IRepository<Professional>
    {
        void SaveProfessional(Professional professional);
        void UpdateProfessional(Professional professional);
        void DeleteProfessional(Guid id);

        Task<Professional> GetProfessionalById(Guid id);
        Task<Professional> GetProfessionalByCode(int code);
        Task<IEnumerable<Professional>> GetAllProfessionals();
        
    }
}