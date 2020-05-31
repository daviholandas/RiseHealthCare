using FluentValidation.Results;
using MediatR;
using System;

namespace RiseHealthCare.Infrastructure.Messages
{
    public abstract class Command : Message, IRequest<ValidationResult>
    {
        protected Command()
        {
            TimeStamp = DateTime.Now;
        }

        public DateTime TimeStamp { get; private set; }
        public ValidationResult ValidationResult { get; private set; }

        public virtual bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}