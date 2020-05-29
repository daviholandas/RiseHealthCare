using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RiseHealth.WebApi.Controllers;
using RiseHealth.WebApi.DTOs.Management;
using RiseHealthCare.Domain.Management;
using RiseHealthCare.Infrastructure.Data.Repositories.Management;

namespace RiseHealth.WebApi.V1.Management
{
    [Route("api/v1/[controller]")]
    public class ProfessionalsController : MainController
    {
        private readonly IProfessionalRepository _professionalRepository;
        private readonly IMapper _mapper;

        public ProfessionalsController(
            IProfessionalRepository professionalRepository, 
            IMapper mapper)
        {
            _professionalRepository = professionalRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<ProfessionalDTO>> ListProfessionals()
            => _mapper.Map<IEnumerable<ProfessionalDTO>>(await _professionalRepository.GetAllProfessionals());
        
        [HttpPost]
        public  ActionResult CreateProfessional(ProfessionalDTO professionalDto)
        {
            var professional = _mapper.Map<Professional>(professionalDto);
             _professionalRepository.SaveProfessional(professional);

             return Ok();
        }
    }
}
