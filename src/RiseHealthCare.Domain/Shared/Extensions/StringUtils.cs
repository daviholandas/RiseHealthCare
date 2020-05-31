using System.Linq;

namespace RiseHealthCare.Domain.Shared.Extensions
{
    public static class StringUtils
    {
        public static string OnlyNumber(this string str, string input) =>
            new string(input.Where(char.IsDigit).ToArray());
    }
}