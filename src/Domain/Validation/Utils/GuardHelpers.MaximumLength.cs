using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validation.Utils;

public static partial class GuardHelpers
{
    public static (bool, string? error) MaximumLength(this string property, int? maximum)
    {
        var length = property.Length;
        if (length > maximum)
        {
            return (false, $"Must be ${length} characters.");
        }
        return (true, null);
    }
}
