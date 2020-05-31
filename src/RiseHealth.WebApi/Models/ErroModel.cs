using System.Collections.Generic;

namespace RiseHealth.WebApi.Models
{
    public class ErrorModel
    {
        public ErrorModel(List<string> errors)
        {
            Errors = errors;
        }

        public List<string> Errors { get; set; }
    }
}