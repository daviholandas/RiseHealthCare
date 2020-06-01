using RiseHealthCare.Domain.Management;
using RiseHealthCare.Domain.Shared.DomainObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RiseHealthCare.Infrastructure.Data.Repositories.Management
{
    public interface IProfessionalRepository : IRepository<Professional>
    {
        Task<int> SaveProfessional(Professional professional);

        void UpdateProfessional(Professional professional);

        void DeleteProfessional(Guid id);

        Task<Professional> GetProfessionalById(Guid id);

        Task<Professional> GetProfessionalByCode(int code);

        Task<IEnumerable<Professional>> GetAllProfessionals();
    }
}