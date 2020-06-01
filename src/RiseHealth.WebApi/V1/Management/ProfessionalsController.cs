using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RiseHealth.WebApi.Controllers;
using RiseHealth.WebApi.DTOs.Management;
using RiseHealthCare.Domain.Management;
using RiseHealthCare.Infrastructure.Data.Repositories.Management;
using System.Collections.Generic;
using System.Threading.Tasks;
using RiseHealth.WebApi.Services.Management;
using RiseHealth.WebApi.ViewModels.Management;

namespace RiseHealth.WebApi.V1.Management
{
    [ApiVersion("1.0")]
    [Route("api/v1/[controller]")]
    public class ProfessionalsController : MainController
    {
        private readonly IProfessionalPersistenceService _professionalPersistence;

        public ProfessionalsController(IProfessionalPersistenceService professionalPersistence)
        {
            _professionalPersistence = professionalPersistence;
        }

        [HttpGet]
        public async Task<IEnumerable<ProfessionalBasicViewModel>> ListProfessionals()
            => await _professionalPersistence.GetAllProfessionals();

        [HttpPost]
        public async Task<ActionResult> CreateProfessional(ProfessionalDto professionalDto)
        {
             var result = await _professionalPersistence.SaveProfessional(professionalDto);
             if (result)
                 return Ok($"{professionalDto.Name} salvo com sucesso!");
             
             return BadRequest($"Não foi possivel salvar {professionalDto.Name}!");
        }
    }
}