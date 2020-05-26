using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace RiseHealth.WebApi.Extensions
{
    public static class ModelStateExtension
    {
        public static List<string> GetErroMessages(this ModelStateDictionary modelState) =>
            modelState.SelectMany(ms => ms.Value.Errors)
                .Select(e => e.ErrorMessage)
                .ToList();
    }
}