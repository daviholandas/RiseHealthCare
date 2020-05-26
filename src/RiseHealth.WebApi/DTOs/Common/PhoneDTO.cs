using RiseHealthCare.Domain.Shared.Enums;

namespace RiseHealth.WebApi.DTOs.Common
{
    public class PhoneDTO
    {
        public NumberType NumberType { get;  set; }
        public string Number { get;  set; }
        public bool IsWhatsapp { get;  set; }
    }
}