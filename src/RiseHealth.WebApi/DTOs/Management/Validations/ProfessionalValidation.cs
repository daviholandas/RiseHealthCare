using FluentValidation;

namespace RiseHealth.WebApi.DTOs.Management.Validations
{
    public class ProfessionalValidation : AbstractValidator<ProfessionalDto>
    {
        public ProfessionalValidation()
        {

            RuleFor(p => p.Name)
                .NotEmpty()
                .WithMessage("Nome do profissional não pode está em branco")
                .MinimumLength(3);
        }
    }
}   