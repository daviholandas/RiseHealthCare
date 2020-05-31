using Bogus;
using RiseHealth.WebApi.DTOs.Management;
using RiseHealthCare.Domain.Management;
using RiseHealthCare.Domain.Management.Enums;
using RiseHealthCare.Domain.Management.ValueObjects;
using System;
using System.Collections.Generic;
using Xunit;

namespace RiseHealthCare.IntegrationTests.Fixtures
{
    [CollectionDefinition(nameof(ProfessionalCollectionFixture))]
    public class ProfessionalCollectionFixture : ICollectionFixture<ProfessionalFixture> { }

    public class ProfessionalFixture
    {
        public Professional GenerateProfessional()
        {
            var professional = new Faker<Professional>("pt_BR")
                .CustomInstantiator(p => new Professional(p.Random.Int(), p.Name.FullName(),
                    p.Image.DataUri(100, 2, "green"),
                    p.Date.Between(new DateTime(2010, 1, 1), DateTime.Today),
                    p.Date.Between(new DateTime(2010, 1, 1), DateTime.Today), null,
                    null, GenerateProcedures(24), p.Random.Bool()
                ));
            return professional;
        }

        public IList<Procedure> GenerateProcedures(int quantity)
        {
            var procedures = new Faker<Procedure>("pt_BR")
                .CustomInstantiator(p => new Procedure(p.Random.Int(), p.Commerce.ProductName(),
                    p.Random.Words(), p.Random.Decimal(min: 1M, max: 5M),
                    p.Random.Decimal(min: 1M, max: 5M), p.Random.Enum<TypeDeduction>()));

            return procedures.Generate(quantity);
        }

        public ProfessionalDTO GenerateProfessionalDto()
        {
            var professionalDto = new Faker<ProfessionalDTO>("pt_BR")
                .RuleFor(p => p.Code, f => f.Random.Int(1, 100))
                .RuleFor(p => p.Name, f => f.Person.FullName)
                .RuleFor(p => p.Procedures, f => GenerateProceduresDtos(20));

            return professionalDto;
        }

        public IEnumerable<ProcedureDto> GenerateProceduresDtos(int quantity)
        {
            var proceduresDto = new Faker<ProcedureDto>("pt_BR")
                .RuleFor(p => p.Code, f => f.Random.Int(1, 200))
                .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                .RuleFor(p => p.Description, f => f.Random.Words(20))
                .RuleFor(p => p.Price, f => f.Random.Decimal(1M, 5M))
                .RuleFor(p => p.Deduction, f => f.Random.Decimal(1M, 5M))
                .RuleFor(p => p.TypeDeduction, f => f.PickRandom<TypeDeduction>());

            return proceduresDto.Generate(quantity);
        }
    }
}