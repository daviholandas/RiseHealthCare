using RiseHealth.WebApi.DTOs.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoMapper.Configuration.Annotations;

namespace RiseHealth.WebApi.DTOs.Management
{
    public class ProfessionalDto
    {
        public string Name { get; set; }
        public string Photo { get; set; }
        public DateTime? HiringDate { get; set; }
        public DateTime? FiringDate { get; set; }
        public CouncilDto Council { get; set; }
        public IList<PhoneDto> Phones { get; set; }
        public IList<ProcedureDto> Procedures { get; set; }
        public bool Active { get; set; }
    }
}