using Footsul.Entities;
using Footsul.Services.Teams.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footsul.Services.Teams.Contracts
{
    public interface TeamRepository
    {
        void Add(Team team);
        List<Team> GetTeams();
        void Update();
        void Delete(Team team);

    }
}
