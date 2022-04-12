using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common;

namespace Domain.Teams.Entities;

internal class TeamName
{
    public string Name { get; init; }
    public string Nickname { get; init; }

    private IValidationGuardClause[] GuardClauses = new[] 
    {  IsNullOrEmptyGuardClause, 
    };

    public TeamName(string name, string nickname)
    {
        Name = name;
        Nickname = nickname;
    }


}
