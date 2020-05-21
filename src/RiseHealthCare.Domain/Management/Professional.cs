using RiseHealthCare.Domain.Management.ValueObjects;
using RiseHealthCare.Domain.Shared.DomainObjects;
using RiseHealthCare.Domain.Shared.ValueObjects;
using System;
using System.Collections.Generic;

namespace RiseHealthCare.Domain.Management
{
    public class Professional : Entity, IAggregateRoot
    {
        public Professional(int code, string name, string photo, DateTime hiringDate, DateTime firingDate,
            Council council, IList<Phone> phones, IList<Procedure> procedures, bool? active)
        {
            Code = code;
            Name = name;
            Photo = photo;
            HiringDate = hiringDate;
            FiringDate = firingDate;
            Council = council;
            Phones = phones ?? new List<Phone>();
            Procedures = procedures ?? new List<Procedure>();
            Active = active ?? true;

            Validate();
        }

        private Professional()
        {
        }

        public int Code { get; private set; }
        public string Name { get; private set; }
        public string Photo { get; private set; }
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

        public (int years, int months, int days) TimeOfWork()
        {
            if (HiringDate.Day <= FiringDate.Day)
            {
                var years = FiringDate.Year - HiringDate.Year;
                var months = FiringDate.Month - HiringDate.Month;
                var days = FiringDate.Day - HiringDate.Day;
                return (years, months, days);
            }
            var time = FiringDate.Subtract(HiringDate.AddYears(1).AddMonths(1).AddDays(2));
            var timeOfWork = new DateTime(time.Ticks);

            return (timeOfWork.Year, timeOfWork.Month, timeOfWork.Day);
        }

        public override void Validate()
        {
            Validations.ValidateIfNull(Code, "Code can't be null.");
            Validations.ValidateIfEmpty(Name, "Name can't be empty.");
        }
    }
}