using FluentValidation.Results;
using MediatR;
using RiseHealthCare.Infrastructure.Messages;
using System.Threading.Tasks;

namespace RiseHealthCare.Infrastructure.Mediator
{
    public class MediatorHandler : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public MediatorHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task PublishEvent<T>(T domainEvent) where T : Event
        {
            await _mediator.Publish(domainEvent);
        }

        public async Task<ValidationResult> SendCommand<T>(T command) where T : Command
        {
            return await _mediator.Send(command);
        }
    }
}