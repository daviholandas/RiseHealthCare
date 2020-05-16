using RiseHealthCare.Domain.Shared.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace RiseHealthCare.Domain.Shared.ValueObjects
{
    public class Address : ValueObject
    {
        private Address()
        {
        }

        public Address(string street, string houseNumber, string neighborhood, string city, string estate, string zipCode, string country)
        {
            Street = street;
            HouseNumber = houseNumber;
            Neighborhood = neighborhood;
            City = city;
            Estate = estate;
            ZipCode = zipCode;
            Country = country;
        }

        public string Street { get; private set; }
        public string HouseNumber { get; private set; }
        public string Neighborhood { get; private set; }
        public string City { get; private set; }
        public string Estate { get; private set; }
        public string ZipCode { get; private set; }
        public string Country { get; private set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Street;
            yield return HouseNumber;
            yield return City;
            yield return Estate;
            yield return ZipCode;
            yield return Country;
        }
    }
}

