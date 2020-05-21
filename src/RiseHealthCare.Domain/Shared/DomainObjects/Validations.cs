using System;
using System.Text.RegularExpressions;

namespace RiseHealthCare.Domain.Shared.DomainObjects
{
    public static class Validations
    {
        public static void ValidateIfEqual(object object1, object object2, string message)
        {
            if (object1.Equals(object2))
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateIfDifferent(object object1, object object2, string message)
        {
            if (!object1.Equals(object2))
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateIfDifferent(string pattern, string value, string message)
        {
            var regex = new Regex(pattern);

            if (!regex.IsMatch(value))
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateSize(string value, int max, string message)
        {
            var length = value.Trim().Length;
            if (length > max)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateSize(string value, int minimum, int max, string message)
        {
            var length = value.Trim().Length;
            if (length < minimum || length > max)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateIfEmpty(string value, string message)
        {
            if (value == null || value.Trim().Length == 0)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateIfNull(object object1, string message)
        {
            if (object1 == null)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateMinimumMax(double value, double minimum, double max, string message)
        {
            if (value < minimum || value > max)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateMinimumMax(float value, float minimum, float max, string message)
        {
            if (value < minimum || value > max)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateMinimumMax(int value, int minimum, int max, string message)
        {
            if (value < minimum || value > max)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateMinimumMax(long value, long minimum, long max, string message)
        {
            if (value < minimum || value > max)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateMinimumMax(decimal value, decimal minimum, decimal max, string message)
        {
            if (value < minimum || value > max)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateIfLessThan(long value, long minimum, string message)
        {
            if (value < minimum)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateIfLessThan(double value, double minimum, string message)
        {
            if (value < minimum)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateIfLessThan(decimal value, decimal minimum, string message)
        {
            if (value < minimum)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateIfLessThan(int value, int minimum, string message)
        {
            if (value < minimum)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateIfLessThan(DateTime value, DateTime minimum, string message)
        {
            if (DateTime.Compare(value, minimum) < 0)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateIfFalse(bool boolvalue, string message)
        {
            if (!boolvalue)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateIfTrue(bool boolvalue, string message)
        {
            if (boolvalue)
            {
                throw new DomainException(message);
            }
        }
    }
}