using FluentAssertions;
using RiseHealthCare.Domain.Management.Enums;
using System;
using Xunit;

namespace RiseHealthCare.DomainTests.Management
{
    [Collection(nameof(ManagementTestsCollection))]
    public class ManagementTests
    {
        private readonly ManagementFixtureTests _managementFixture;

        public ManagementTests(ManagementFixtureTests managementFixture)
        {
            _managementFixture = managementFixture;
        }

        [Theory(DisplayName = "Testing calculation comission per procedure")]
        [InlineData(120, 30, 90, TypeDeduction.Fixed)]
        [InlineData(250, 25.5, 186.25, TypeDeduction.Percent)]
        [InlineData(20, 25.5, 20, TypeDeduction.Percent)]
        public void Procedure_CalculationComission_CorrectCalculation(decimal price, decimal deduction, decimal comission, TypeDeduction typeDeduction)
        {
            //Arrange
            var procedure = _managementFixture.GenareteProcedure(price, deduction, typeDeduction);
            //Act
            var resultComission = procedure.CalculateComission();
            //Assert
            resultComission.Should().Equals(comission);
        }

        [Fact(DisplayName = "Testing add range procedure for professional")]
        public void Professional_AddProcedure_AddRangeProcedure()
        {
            //Arrange
            var procedures = _managementFixture.GenerateProcedures(10);
            var professional = _managementFixture.GenareteProfessionalWithOutPorcedures();
            //Act
            foreach (var procedure in procedures)
            {
                professional.AddProcedure(procedure);
            }
            //Assert
            professional.Procedures.Should().HaveCount(10);
        }

        [Fact(DisplayName = "Testing calculation time of work for professional")]
        public void Profissional_CalculationTimeOfWork()
        {
            
        }
    }
}