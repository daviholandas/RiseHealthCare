using RiseHealthCare.Domain.Shared.DomainObjects;
using RiseHealthCare.Domain.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RiseHealthCare.Domain.Shared.ValueObjects
{
    public class Phone : ValueObject
    {
        public Phone(NumberType? numberType, string number, bool? isWhatsapp)
        {
            NumberType = numberType ?? NumberType.Cellphone;
            Number = number;
            IsWhatsapp = isWhatsapp ?? true;
        }
        private Phone() { }

        public NumberType NumberType { get; private set; }
        public string Number { get; private set; }
        public bool IsWhatsapp { get; private set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return NumberType;
            yield return Number;
            yield return IsWhatsapp;
        }
    }
}
