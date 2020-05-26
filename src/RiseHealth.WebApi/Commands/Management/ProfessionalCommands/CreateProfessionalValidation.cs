using FluentValidation;
using RiseHealthCare.Domain.Management;

namespace RiseHealth.WebApi.Commands.Management.ProfessionalCommands
{
    public class CreateProfessionalValidation : AbstractValidator<CreateProfessionalCommand>
    {
        public CreateProfessionalValidation()
        {
            RuleFor(cp => cp.Code)
                .NotNull()
                .WithMessage("O codigo não pode ser null.");

            RuleFor(cp => cp.Name)
                .NotEmpty()
                .WithMessage("Nome do profissional não pode está vazio.");
        }
    }
}