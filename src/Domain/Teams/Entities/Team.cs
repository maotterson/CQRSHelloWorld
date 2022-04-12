using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Teams.Entities;

public class Team
{
    private readonly TeamName teamName;
    public string Name => teamName.Name;
    public string Nickname => teamName.Nickname;

    public Team(TeamName teamName)
    {
        this.teamName = teamName;
    }


}
