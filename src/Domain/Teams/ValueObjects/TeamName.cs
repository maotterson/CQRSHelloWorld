using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Validation.Entities;
using Domain.Validation.Enumss;
using Domain.Validation.Utils;

namespace Domain.Teams.Entities;

public class TeamName
{
    public string Name { get; init; }
    private static readonly PropertyRules nameRules = new(
        (GuardClause.MAXIMUM_LENGTH,20),
        (GuardClause.MINIMUM_LENGTH,6),
        (GuardClause.NULL_OR_EMPTY,null));
    public string Nickname { get; init; }
    private static readonly PropertyRules nicknameRules = new(
        (GuardClause.MAXIMUM_LENGTH, 20),
        (GuardClause.MINIMUM_LENGTH, 6),
        (GuardClause.NULL_OR_EMPTY, null));


    public TeamName(string name, string nickname)
    {
        Name = name.GuardAgainst(nameRules);
        Nickname = nickname.GuardAgainst(nicknameRules);
    }

}
