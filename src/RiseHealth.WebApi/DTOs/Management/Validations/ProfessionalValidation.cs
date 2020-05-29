using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace RiseHealth.WebApi.DTOs.Management.Validations
{
    public class ProfessionalValidation : AbstractValidator<ProfessionalDTO>
    {
        public ProfessionalValidation()
        {
            RuleFor(p => p.Code)
                .NotNull()
                .WithMessage("O codigo não pode ser nulo. ");

            RuleFor(p => p.Name)
                .NotEmpty()
                .WithMessage("Nome do profissional não pode está em branco");
        }
    }
}
