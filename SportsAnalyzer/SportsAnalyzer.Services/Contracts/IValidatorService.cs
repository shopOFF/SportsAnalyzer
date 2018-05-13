using System;
using System.Collections.Generic;
using System.Text;

namespace SportsAnalyzer.Services.Contracts
{
    public interface IValidatorService
    {
        void CheckIfStringIsNullOrEmpty(string value, string message = null);
        void CheckIfObjectIsNull(object obj, string message = null);
    }
}
