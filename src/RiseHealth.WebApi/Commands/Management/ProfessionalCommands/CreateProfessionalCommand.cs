using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RiseHealthCare.Domain.Management.ValueObjects;
using RiseHealthCare.Domain.Shared.ValueObjects;
using RiseHealthCare.Infrastructure.Messages;

namespace RiseHealth.WebApi.Commands.Management.ProfessionalCommands
{
    public class CreateProfessionalCommand : Command
    {
        [Key]
        public Guid Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public DateTime HiringDate { get; set; }
        public DateTime FiringDate { get; set; }
        public Council Council { get; set; }
        public IList<Phone> Phones { get; set; }
        public IList<Procedure> Procedures { get; set; }
        public bool Active { get; set; }
    }
}