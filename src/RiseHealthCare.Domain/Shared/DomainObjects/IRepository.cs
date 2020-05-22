using System;

namespace RiseHealthCare.Domain.Shared.DomainObjects
{
    public interface IRepository<T> : IDisposable where T : Entity
    {
        
    }
}