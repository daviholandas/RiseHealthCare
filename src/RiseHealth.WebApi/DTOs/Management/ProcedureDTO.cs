using RiseHealthCare.Domain.Management.Enums;

namespace RiseHealth.WebApi.DTOs.Management
{
    public class ProcedureDto
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Deduction { get; set; }
        public TypeDeduction TypeDeduction { get; set; }
    }
}