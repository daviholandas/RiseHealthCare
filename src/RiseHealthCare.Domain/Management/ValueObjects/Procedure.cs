using RiseHealthCare.Domain.Management.Enums;
using RiseHealthCare.Domain.Shared.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace RiseHealthCare.Domain.Management.ValueObjects
{
    public class Procedure : ValueObject
    {
        public Procedure(int code, string name, string description, decimal price, decimal deduction, TypeDeduction?  typeDeduction)
        {
            Code = code;
            Name = name;
            Description = description;
            Price = price;
            Deduction = deduction;
            TypeDeduction = typeDeduction ?? TypeDeduction.Fixed;
        }
        private Procedure() { }

        public int Code { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public decimal Deduction { get; private set; }
        public TypeDeduction TypeDeduction { get; private set; }


        public decimal CalculateComission() =>
           TypeDeduction switch
           {   TypeDeduction.Fixed => Deduction > Price ? Price : Price - Deduction,
               TypeDeduction.Percent => Deduction > Price ? Price : Price - (Price * Deduction / 100),
               _ => Price
           };


        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Code;
            yield return Name;
            yield return Price;
            yield return Deduction;
            yield return TypeDeduction;
        }
    }
}
