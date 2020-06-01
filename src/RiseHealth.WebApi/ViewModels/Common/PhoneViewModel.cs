using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RiseHealthCare.Domain.Shared.Enums;

namespace RiseHealth.WebApi.ViewModels.Management
{
    public class PhoneViewModel
    {
        public NumberType NumberType { get; set; }
        public string Number { get; set; }
        public bool IsWhatsapp { get; set; }
    }
}
