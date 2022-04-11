using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common.Validation.Rules;

namespace Domain.Common.Validation;

public static class InputValidator
{
    public static Func<string, (bool isValid,string error)> IsValid(this string obj, (ValidationRule Rule, int Value) option) =>
        option.Rule switch
        {
            ValidationRule.NULL => throw new NotImplementedException(),
            ValidationRule.NULL_OR_EMPTY => (obj) => InputValidationResolver.CheckIsNotNull(obj),
            ValidationRule.MINIMUMLENGTH => (obj,option.Value) =>
            ValidationRule.MAXIMUMLENGTH => throw new NotImplementedException(),
            _ => throw new NotImplementedException(),
        };
}
