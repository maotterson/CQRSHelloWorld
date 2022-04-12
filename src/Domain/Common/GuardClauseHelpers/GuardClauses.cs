using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common.GuardClauseHelpers;

internal enum GuardClause
{
    NULL_OR_EMPTY,
    MINIMUM_LENGTH,
    MAXIMUM_LENGTH
}
