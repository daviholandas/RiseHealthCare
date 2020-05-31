using RiseHealthCare.Domain.Shared.Enums;

namespace RiseHealth.WebApi.DTOs.Common
{
    public class PhoneDto
    {
        public NumberType NumberType { get; set; }
        public string Number { get; set; }
        public bool IsWhatsapp { get; set; }
    }
}