using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validation.Utils;

public static partial class GuardHelpers
{
    public static (bool, string? error) MinimumLength(this string property, int? minimum)
    {
        var length = property.Length;
        if (length < minimum)
        {
            return (false, $"Must be at least ${length} characters.");
        }
        return (true, null);
    }
}
