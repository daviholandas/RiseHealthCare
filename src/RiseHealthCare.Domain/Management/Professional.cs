﻿using RiseHealthCare.Domain.Management.ValueObjects;
using RiseHealthCare.Domain.Shared.DomainObjects;
using RiseHealthCare.Domain.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace RiseHealthCare.Domain.Management
{
    public class Professional : Entity, IAggregateRoot
    {
        public Professional(int code, string name, DateTime hiringDate, DateTime firingDate,
            Council council, IList<Phone> phones, IList<Procedure> procedures, bool? active)
        {
            Code = code;
            Name = name;
            HiringDate = hiringDate;
            FiringDate = firingDate;
            Council = council;
            Phones = phones ?? new List<Phone>();
            Procedures = procedures ?? new List<Procedure>();
            Active = active ?? true;

            Validate();
        }

        private Professional() { }

        public int Code { get; private set; }
        public string Name { get; private set; }
        public DateTime HiringDate { get; private set; }
        public DateTime FiringDate { get; private set; }
        public Council Council { get; private set; }
        public IList<Phone> Phones { get; private set; }
        public IList<Procedure> Procedures { get; private set; }
        public bool Active { get; private set; }


        public void AddProcedure(Procedure procedure)
        {
            Procedures.Add(procedure);
        }

        public override void Validate()
        {
            Validations.ValidateIfNull(Code, "Code can't be null.");
            Validations.ValidateIfEmpty(Name, "Name can't be empty.");
        }
    }
}
