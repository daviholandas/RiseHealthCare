using Bogus;
using RiseHealthCare.Domain.Management;
using RiseHealthCare.Domain.Management.Enums;
using RiseHealthCare.Domain.Management.ValueObjects;
using System;
using System.Collections.Generic;
using Xunit;

namespace RiseHealthCare.DomainTests.Management
{
    [CollectionDefinition(nameof(ManagementTestsCollection))]
    public class ManagementTestsCollection : ICollectionFixture<ManagementFixtureTests> { }

    public class ManagementFixtureTests
    {
        public Professional GenareteProfessionalWithOutPorcedures()
        {
            var professional = new Faker<Professional>("pt_BR")
                .CustomInstantiator(p => new Professional(p.Random.Int(), p.Name.FullName(),p.Image.DataUri(100, 2,"green"), p.Date.Between(new DateTime(2010, 1, 1), DateTime.Today),
                    p.Date.Between(new DateTime(2010, 1, 1), DateTime.Today), null, null, null, p.Random.Bool()
                ));

            return professional;
        }

        public IEnumerable<Procedure> GenerateProcedures(int quantity)
        {
            var procedures = new Faker<Procedure>("pt_BR")
                .CustomInstantiator(p => new Procedure(p.Random.Int(), p.Commerce.ProductName(), p.Random.Words(), p.Random.Decimal(min: 1M, max: 5M), p.Random.Decimal(min: 1M, max: 5M), p.Random.Enum<TypeDeduction>()));

            return procedures.Generate(quantity);
        }

        public Procedure GenareteProcedure(decimal price, decimal deduction, TypeDeduction typeDeduction)
        {
            var procedures = new Faker<Procedure>("pt_BR")
                .CustomInstantiator(p => new Procedure(p.Random.Int(), p.Commerce.ProductName(), p.Random.Words(), price, deduction, typeDeduction));

            return procedures;
        }

        public Professional GenareteProfessionalWithOutHiringAndFiringDate(DateTime hiringDate, DateTime firingDate)
        {
            var professional = new Faker<Professional>("pt_BR")
                .CustomInstantiator(p => new Professional(p.Random.Int(), p.Name.FullName(), p.Image.DataUri(100, 2, "green"), hiringDate,
                    firingDate, null, null, null, p.Random.Bool()
                ));

            return professional;
        }
    }
}