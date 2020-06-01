using Microsoft.EntityFrameworkCore;
using RiseHealthCare.Domain.Management;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RiseHealthCare.Infrastructure.Data.Repositories.Management
{
    public class ProfessionalRepository : IProfessionalRepository
    {
        public ProfessionalRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        private readonly ApplicationDbContext _context;

        public async Task<int> SaveProfessional(Professional professional)
        {
            _context.Professionals.Add(professional); 
           return await  _context.SaveChangesAsync();
        }

        public void UpdateProfessional(Professional professional)
        {
            _context.Professionals.Update(professional);
            _context.SaveChangesAsync();
        }

        public void DeleteProfessional(Guid id)
        {
            var professional = GetProfessionalById(id).Result;
            _context.Professionals.Remove(professional);
        }

        public async Task<Professional> GetProfessionalById(Guid id)
        {
            return await _context.Professionals.AsNoTracking()
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Professional> GetProfessionalByCode(int code)
        {
            return await _context.Professionals.AsNoTracking()
                .FirstOrDefaultAsync(p => p.Code == code);
        }

        public async Task<IEnumerable<Professional>> GetAllProfessionals()
        {
            return await _context.Professionals.ToListAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}