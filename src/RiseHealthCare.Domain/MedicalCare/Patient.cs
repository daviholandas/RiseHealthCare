using RiseHealthCare.Domain.Management;
using RiseHealthCare.Domain.Shared.DomainObjects;
using RiseHealthCare.Domain.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace RiseHealthCare.Domain.MedicalCare
{
    public class Patient : Entity, IAggregateRoot
    {
        public Patient(string name, DateTime birthDate, Genre genre, string cPF, string rG, string informations, Address address, Phone phone, Guid insuranceHealthId)
        {
            Name = name;
            BirthDate = birthDate;
            Genre = genre;
            CPF = cPF;
            RG = rG;
            Informations = informations;
            Address = address;
            Phone = phone;
            InsuranceHealthId = insuranceHealthId;

            Validate();
        }

        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public Genre Genre { get; private set; }
        public string CPF { get; private set; }
        public string RG { get; private set; }
        public string Informations { get; private set; }
        public Address Address { get; private set; }
        public Phone Phone { get; private set; }
        public InsuranceHeatlh InsuranceHealth { get; private set; }

        //EF Relations
        public Guid? InsuranceHealthId { get; private set; }

        public string AgeInfomation()
        {
            var time = DateTime.Today.Subtract(BirthDate.AddYears(1).AddMonths(1).AddDays(2));
            var age = new DateTime(time.Ticks);

            return $"{age.Year} anos, {age.Month} meses e {age.Day} dias.";
        }

        public void ChangeInsuranceHealth(InsuranceHeatlh insurance)
        {
            InsuranceHealth = insurance;
            InsuranceHealthId = insurance.Id;        
        }

        public override void Validate()
        {
            Validations.ValidateIfEmpty(Name, "Name can't be empty.");
            Validations.ValidateIfEmpty(CPF, "CPF can't be empty");
            Validations.ValidateIfNull(Genre, "Genre can't be null");
        }
    }
}
