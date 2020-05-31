using FluentValidation.Results;
using RiseHealthCare.Infrastructure.Messages;
using System.Threading.Tasks;

namespace RiseHealthCare.Infrastructure.Mediator
{
    public interface IMediatorHandler
    {
        Task PublishEvent<T>(T domainEvent) where T : Event;

        Task<ValidationResult> SendCommand<T>(T command) where T : Command;
    }
}