using Bogus;
using Bogus.Extensions.Brazil;
using Bogus.Extensions.Denmark;
using RiseHealthCare.Domain.MedicalCare;
using RiseHealthCare.Domain.Shared.ValueObjects;
using System;
using Xunit;

namespace RiseHealthCare.DomainTests.MedicalCare
{
    [CollectionDefinition(nameof(MedicalCareTestsCollection))]
    public class MedicalCareTestsCollection : ICollectionFixture<MedicalCareFixtureTests> { }

    public class MedicalCareFixtureTests
    {
        public Patient GeneratePatient()
        {
            var patient = new Faker<Patient>("pt_BR")
                .CustomInstantiator(p => new Patient(p.Name.FullName(), p.Date.Between(new DateTime(1920, 1, 1), DateTime.Now),
                p.Random.Enum<Genre>(), p.Person.Cpf(), p.Person.Cpr(), p.Random.Words(5), null, null, p.Image.DataUri(100, 2, "green"), Guid.NewGuid()));

            return patient;
        }

        public Patient GeneratePatientWithoutBirthDate(DateTime birthDate)
        {
            var patient = new Faker<Patient>("pt_BR")
                .CustomInstantiator(p => new Patient(p.Name.FullName(), birthDate,
                p.Random.Enum<Genre>(), p.Person.Cpf(), p.Person.Cpr(), p.Random.Words(5), null, null, p.Image.DataUri(100, 2, "green"), Guid.NewGuid()));

            return patient;
        }
    }
}