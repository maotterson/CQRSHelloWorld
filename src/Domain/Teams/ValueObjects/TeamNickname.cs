using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common.Validation;
using Domain.Common.Validation.Rules;
using FluentResults;

namespace Domain.Teams.ValueObjects;

public record TeamNickname
{
    public string Value { get; }
    private static readonly ValidationOptions rules = new(
            (ValidationRule.NULL_OR_EMPTY, null),
            (ValidationRule.MINIMUMLENGTH, 6),
            (ValidationRule.MAXIMUMLENGTH, 20));

    private TeamNickname(string value)
    {
        Value = value;
    }

    public static Result<TeamNickname> Create(string value)
    {
        var teamNickname = new TeamNickname(value);
        var (isValid, error) = teamNickname.IsValid(rules);

        return isValid ? Result.Ok(teamNickname) : Result.Fail(error);
    }
}
internal static class NicknameExtensions
{
    public static (bool,string) IsValid(this TeamNickname nickname, ValidationOptions rules)
    {
        var isValid = true;
        var error = "";
        return (isValid, error);
    }
}
