using AutoMapper;
using Moq;
using RiseHealth.WebApi.DTOs.Management;
using RiseHealth.WebApi.Setup;
using RiseHealthCare.Domain.Management;
using RiseHealthCare.IntegrationTests.Fixtures;
using Xunit;

namespace RiseHealthCare.IntegrationTests
{
    [Collection(nameof(ProfessionalCollectionFixture))]
    public class AutoMapperProfileTests
    {
        private readonly ProfessionalFixture _professionalFixture;

        public AutoMapperProfileTests(ProfessionalFixture professionalFixture)
        {
            _professionalFixture = professionalFixture;
        }

        [Fact(DisplayName = "Testing autoMapper profile DtoToDomain.")]
        public void AutoMapperProfile_DtoToDomainMappingProfile_MappingWorking()
        {
            //Arrange
            var professionalDto = _professionalFixture.GenerateProfessionalDto();
            var autoMapper = new Mock<IMapper>();

            //Act
            var autoMapperConfig = new MapperConfiguration(cfg =>
                cfg.AddProfile(new AutoMapperProfile()));

            var mapper = autoMapperConfig.CreateMapper();
            var professional = mapper.Map<Professional>(professionalDto);

            //Assert
            Assert.Same(professional.Name, professionalDto.Name);
        }

        [Fact(DisplayName = "Testing autoMapper profile DomainToDtoMapping.")]
        public void AutoMapperProfile_DomainToDtoMappingProfile_MappingWorking()
        {
            //Arrange
            var professional = _professionalFixture.GenerateProfessional();
            var autoMapperConfig = new MapperConfiguration(cfg =>
                cfg.AddProfile(new AutoMapperProfile()));

            //Act
            var maper = autoMapperConfig.CreateMapper();
            var profissionalDto = maper.Map<ProfessionalDTO>(professional);

            //Assert
            Assert.Equal(professional.Name, profissionalDto.Name);
        }
    }
}