using RiseHealthCare.Domain.Shared.DomainObjects;
using System;
using System.Collections.Generic;

namespace RiseHealthCare.Domain.Management.ValueObjects
{
    public class Council : ValueObject
    {
        public Council(string name, string registrationCode, bool? registrationIsValid, DateTime? endToRegistration)
        {
            Name = name;
            RegistrationCode = registrationCode;
            RegistrationIsValid = registrationIsValid;
            EndToRegistration = endToRegistration;
        }

        private Council()
        {
        }

        public string Name { get; private set; }
        public string RegistrationCode { get; private set; }
        public bool? RegistrationIsValid { get; private set; }
        public DateTime? EndToRegistration { get; protected set; }
        
        public override string ToString() => $"{Name} - {RegistrationCode}";
        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Name;
            yield return RegistrationCode;
            yield return RegistrationIsValid;
            yield return EndToRegistration;
        }
    }
}