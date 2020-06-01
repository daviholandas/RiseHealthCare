using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RiseHealthCare.Domain.Management.Enums;

namespace RiseHealth.WebApi.ViewModels.Management
{
    public class ProcedureViewModel
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Deduction { get; set; }
        public TypeDeduction TypeDeduction { get; set; }
    }
}
