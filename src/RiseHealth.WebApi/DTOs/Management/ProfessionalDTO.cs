using System;
using System.Collections.Generic;
using RiseHealth.WebApi.DTOs.Common;
using RiseHealthCare.Domain.Management.ValueObjects;
using RiseHealthCare.Domain.Shared.ValueObjects;

namespace RiseHealth.WebApi.DTOs.Management
{
    public class ProfessionalDTO
    {
        public Guid Id {get; set;}
        public int Code { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public DateTime HiringDate { get; set; }
        public DateTime FiringDate { get; set; }
        public CouncilDTO Council { get; set; }
        public IList<PhoneDTO> Phones { get; set; }
        public IList<ProcedureDTO> Procedures { get; set; }
        public bool Active { get; set; }
    }
}