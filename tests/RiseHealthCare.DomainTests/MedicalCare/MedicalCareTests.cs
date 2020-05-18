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
            var patient = _fixtureTests.GeneratePatientWithoutBirthDate(new DateTime(1985,12,22));
            var patient2 = _fixtureTests.GeneratePatientWithoutBirthDate(new DateTime(1980,05,18));
            //Act
            var ageInformation = patient.AgeInfomation();
            var ageInformation2 = patient2.AgeInfomation();
            //Assert
            Assert.Equal("34 anos, 4 meses e 27 dias.", ageInformation);
        }
    }
}
