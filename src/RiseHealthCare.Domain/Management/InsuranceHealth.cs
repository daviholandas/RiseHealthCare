using RiseHealthCare.Domain.Management.Enums;
using RiseHealthCare.Domain.MedicalCare;
using RiseHealthCare.Domain.Shared.DomainObjects;
using System.Collections.Generic;

namespace RiseHealthCare.Domain.Management
{
    public class InsuranceHealth : Entity
    {
        public InsuranceHealth(int code, string name, DiscountType? discountType, decimal discount)
        {
            Code = code;
            Name = name;
            DiscountType = discountType ?? DiscountType.NoDiscount;
            Discount = discount;

            Validate();
        }

        private InsuranceHealth()
        {
        }

        public int Code { get; private set; }
        public string Name { get; private set; }
        public DiscountType DiscountType { get; private set; }
        public decimal Discount { get; private set; }

        //Relation to EntityCore
        public IEnumerable<Patient> Patients { get; private set; }

        public override void Validate()
        {
            Validations.ValidateIfNull(Code, "Code can't be null.");
            Validations.ValidateIfEmpty(Name, "Name can't be empty.");
        }
    }
}