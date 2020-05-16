using RiseHealthCare.Domain.Management.ValueObjects;
using RiseHealthCare.Domain.Shared.DomainObjects;
using RiseHealthCare.Domain.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace RiseHealthCare.Domain.Management
{
    public class Professional : Entity
    {
        public Professional(int code, string name, DateTime hiringDate, DateTime firingDate,
            Council council, IList<Phone> phones, IList<Procedure> procedures)
        {
            Code = code;
            Name = name;
            HiringDate = hiringDate;
            FiringDate = firingDate;
            Council = council;
            Phones = phones ?? new List<Phone>();
            Procedures = procedures ?? new List<Procedure>();
        }

        private Professional() { }

        public int Code { get; private set; }
        public string Name { get; private set; }
        public DateTime HiringDate { get; private set; }
        public DateTime FiringDate { get; private set; }
        public Council Council { get; private set; }
        public IList<Phone> Phones { get; private set; }
        public IList<Procedure> Procedures { get; private set; }


        public void AddProcedure(Procedure procedure)
        {
            Procedures.Add(procedure);
        }
    }
}
