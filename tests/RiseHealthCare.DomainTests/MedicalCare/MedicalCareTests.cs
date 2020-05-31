using FluentAssertions;
using RiseHealthCare.Domain.Shared.ValueObjects;
using Xunit;

namespace RiseHealthCare.DomainTests.MedicalCare
{
    [Collection(nameof(MedicalCareTestsCollection))]
    public class MedicalCareTests
    {
        private readonly MedicalCareFixtureTests _fixtureTests;

        public MedicalCareTests(MedicalCareFixtureTests fixtureTests)
        {
            _fixtureTests = fixtureTests;
        }

        [Fact(DisplayName = "Testing show age information.")]
        public void Patient_ShowAge_ShowingCorrectAgeInformation()
        {
        }

        [Theory(DisplayName = "Testing validation CPF.")]
        [InlineData("017.333.663-93", true)]
        [InlineData("11111111193", false)]
        [InlineData("222.222.222-22", false)]
        public void CPF_CPFVerification(string cpf, bool resultValidation)
        {
            //Arrange

            //Act
            var result = CPF.Validate(cpf);
            //Assert
            result.Should().Be(resultValidation);
        }
    }
}