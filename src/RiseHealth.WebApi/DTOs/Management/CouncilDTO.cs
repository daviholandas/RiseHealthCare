using System;

namespace RiseHealth.WebApi.DTOs.Management
{
    public class CouncilDTO
    {
        public string Name { get; set; }
        public string RegistrationCode { get; set; }
        public bool? RegistrationIsValid { get; set; }
        public DateTime? EndToRegistration { get; set; }
    }
}