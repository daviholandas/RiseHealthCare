using System;
using MediatR;

namespace RiseHealthCare.Infrastructure.Messages
{
    public class Event : Message, INotification
    {
        protected Event()
        {
            TimeStamp = DateTime.Now;
        }
        public DateTime TimeStamp { get; private set; }
    }
}