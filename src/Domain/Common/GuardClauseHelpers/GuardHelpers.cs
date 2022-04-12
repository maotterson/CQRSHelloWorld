using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common.GuardClauseHelpers;

public static partial class GuardHelpers
{
    public static (bool isValid, string[]? error) GuardAgainst(this string property, params (GuardClause clause, int? value)[] rules)
    {
        foreach(var rule in rules)
        {
            property.Check(rule);
        }
    }

    private static (bool isValid, string? error) Check(this string property, (GuardClause clause, int? value) rule)
        => rule.clause switch
        {
            GuardClause.NULL_OR_EMPTY => property.NullOrEmpty(),
            GuardClause.MINIMUM_LENGTH => property.MinimumLength(rule.value),
            GuardClause.MAXIMUM_LENGTH => property.MaximumLength(rule.value),
            _ => throw new NotImplementedException(),
        };
}
