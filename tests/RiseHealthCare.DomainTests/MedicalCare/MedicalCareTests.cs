using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
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


        [Fact(DisplayName ="Testing show age information.")]
        public void Patient_ShowAge_ShowingCorrectAgeInformation()
        {
            //Arrange
            var patient = _fixtureTests.GeneratePatientWithoutBirthDate(new DateTime(1985,12,23));
            var patient2 = _fixtureTests.GeneratePatientWithoutBirthDate(new DateTime(1980,05,17));
            //Act
            var ageInformation = patient.Age();
            var ageInformation2 = patient2.Age();
            var ageExpected1 = (40, 0, 1);
            var ageExpected2 = (34,4,25);
            //Assert
            ageInformation2.Should().BeEquivalentTo(ageExpected1);
            ageInformation.Should().BeEquivalentTo(ageExpected2);
        }
    }
}
