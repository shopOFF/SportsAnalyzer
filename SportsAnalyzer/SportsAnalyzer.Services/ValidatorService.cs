using SportsAnalyzer.Services.Contracts;
using System;

namespace SportsAnalyzer.Services
{
    public class ValidatorService : IValidatorService
    {
        public void CheckIfStringIsNullOrEmpty(string value, string message = null)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException($"{value} was null or empty. - {message}");
            }
        }

        public void CheckIfObjectIsNull(object obj, string message = null)
        {
            if (obj == null)
            {
                throw new NullReferenceException($"{obj} was null or empty. - {message}");
            }
        }

    }
}
