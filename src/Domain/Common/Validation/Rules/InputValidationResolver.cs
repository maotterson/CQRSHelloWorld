using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common.Validation.Rules;

public static class InputValidationResolver
{
    private readonly static string error = "Error: cannot be null";
    public static (bool isValid, string error) CheckIsNotNull(string obj) 
    {
        if (obj is not null) return (true, "");
        return (false, error);
    }
}
