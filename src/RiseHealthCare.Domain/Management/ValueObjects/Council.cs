using RiseHealthCare.Domain.Shared.DomainObjects;
using System;
using System.Collections.Generic;

namespace RiseHealthCare.Domain.Management.ValueObjects
{
    public class Council : ValueObject
    {
        public Council(string name, string registrationCode, string estate)
        {
            Name = name;
            RegistrationCode = registrationCode;
            Estate = estate;

        }

        private Council()
        {
        }

        public string Name { get; private set; }
        public string RegistrationCode { get; private set; }
        public string Estate { get; private set; }

        public override string ToString() => $"{Name} - {RegistrationCode}/{Estate}";


        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Name;
            yield return RegistrationCode;
        }
    }
}