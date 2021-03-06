﻿using System;

namespace RiseHealthCare.Domain.Shared.DomainObjects
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
            RegisterDate = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public DateTime RegisterDate { get; set; }
        public DateTime? LastModified { get; set; }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Entity;

            if (ReferenceEquals(null, compareTo)) return false;
            if (ReferenceEquals(this, compareTo)) return true;

            return Id.Equals(compareTo.Id);
        }

        public static bool operator ==(Entity a, Entity b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null)) return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;

            return a.Equals(b);
        }

        public static bool operator !=(Entity a, Entity b) => !(a == b);

        public override int GetHashCode() => (GetType().GetHashCode() * 908) + Id.GetHashCode();

        public override string ToString() => $"{GetType().Name} - [ID={Id}]";

        public abstract void Validate();
    }
}