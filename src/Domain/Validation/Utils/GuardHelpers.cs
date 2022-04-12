using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Validation.Entities;
using Domain.Validation.Enumss;

namespace Domain.Validation.Utils;

public static partial class GuardHelpers
{
    public static string GuardAgainst(this string property, PropertyRules rules)
    {
        foreach(var rule in rules)
        {
            var (isValid, error) = property.Check(rule);
            if (!isValid) throw new(error);
        }
        return property;
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
