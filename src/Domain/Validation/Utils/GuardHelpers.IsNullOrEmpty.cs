using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validation.Utils;

public static partial class GuardHelpers
{
    public static (bool, string? error) NullOrEmpty(this string property)
    {
        if(property is null || property == "")
        {
            return (false, "Cannot be null or empty.");
        }
        return (true, null);
    }
}
