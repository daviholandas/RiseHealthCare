using System.Threading;
using System.Threading.Tasks;
using FluentValidation.Results;
using MediatR;

namespace RiseHealth.WebApi.Commands.Management.ProfessionalCommands
{
    public class ProfessionalCommandHandler : IRequestHandler<CreateProfessionalCommand, ValidationResult>
    {
        public Task<ValidationResult> Handle(CreateProfessionalCommand command, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}