using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RiseHealth.WebApi.DTOs.Common;
using RiseHealth.WebApi.DTOs.Management;

namespace RiseHealth.WebApi.ViewModels.Management
{
    public class ProfessionalViewModel
    {
        public Guid Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public DateTime? HiringDate { get; set; }
        public DateTime? FiringDate { get; set; }
        public string Council { get; set; }
        public IList<ProcedureViewModel> Phones { get; set; }
        public IList<ProcedureViewModel> Procedures { get; set; }
        public bool Active { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
