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
        public Guid Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public DateTime? HiringDate { get; set; }
        public DateTime? FiringDate { get; set; }
        public string CouncilToString { get; set; }
        public CouncilDto Council { get; set; }
        public IList<PhoneDto> Phones { get; set; }
        public IList<ProcedureDto> Procedures { get; set; }
        public bool Active { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime? LastModified { get; set; }
    }
}