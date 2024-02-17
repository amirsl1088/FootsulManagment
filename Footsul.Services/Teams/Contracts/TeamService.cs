using Footsul.Entities;
using Footsul.Services.Teams.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footsul.Services.Teams.Contracts
{
    public interface TeamService
    {
        Task Add(AddTeamDto dto);
        List<GetTeamDto> GetTeams(FilterTeamDto dto);
        Task Update(int id,UpdateTeamDto dto);
        Task Delete(DeleteTeamDto dto);
    }
}
