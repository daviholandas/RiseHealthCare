using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using RiseHealth.WebApi.Extensions;
using RiseHealth.WebApi.Models;

namespace RiseHealth.WebApi.Filters
{
    public class ModelStateValidatorFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var errors = new ErrorModel(context.ModelState.GetErrorsMessages());
                context.Result = new BadRequestObjectResult(errors);
            }
        }
    }
}