using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common.Validation;

public enum ValidationRule
{
    NULL,
    NULL_OR_EMPTY,
    MINIMUMLENGTH,
    MAXIMUMLENGTH
}
