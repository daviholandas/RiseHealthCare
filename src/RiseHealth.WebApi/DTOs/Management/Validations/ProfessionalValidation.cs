using FluentValidation;

namespace RiseHealth.WebApi.DTOs.Management.Validations
{
    public class ProfessionalValidation : AbstractValidator<ProfessionalDto>
    {
        public ProfessionalValidation()
        {

            RuleFor(p => p.Name)
                .Cascade(CascadeMode.Continue)
                .NotEmpty()
                .WithMessage("Nome do profissional não pode está em branco.")
                .MinimumLength(3)
                .WithMessage("O nome do professional não pode ter menos de 3 caracters.");
        }
    }
}   