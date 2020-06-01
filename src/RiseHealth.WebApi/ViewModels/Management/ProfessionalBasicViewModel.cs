using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiseHealth.WebApi.ViewModels.Management
{
    public class ProfessionalBasicViewModel
    {
        public Guid Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Council { get; set; }
        public IList<ProcedureViewModel> Procedures { get; set; }
        public bool Active { get; set; }
    }
}
