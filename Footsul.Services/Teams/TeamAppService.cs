using Footsul.Entities;
using Footsul.Services.Teams.Contracts;
using Footsul.Services.Teams.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taav.Contracts;

namespace Footsul.Services.Teams
{
    public class TeamAppService : TeamService
    {
        private readonly TeamRepository _teamrepository;
        private readonly IUnitOfWork _unitofwork;
        public TeamAppService(TeamRepository teamRepository,
            IUnitOfWork unitOfWork)
        {
            _teamrepository = teamRepository;
            _unitofwork = unitOfWork;
        }
        public async Task Add(AddTeamDto dto)
        {
            var team = new Team
            {
                Name = dto.Name,
                FirstKit = dto.FirstKit,
                SecondKit = dto.SecondKit
            };
            if (team.FirstKit == team.SecondKit)
            {
                throw new Exception("you choose same kit");
            }
            var result = _teamrepository.GetTeams().Any(_ => _.Name == team.Name);
            if (result == true)
            {
                throw new Exception("you choose same name");
            }
            _teamrepository.Add(team);
            await _unitofwork.Complete();
        }

        public async Task Delete(DeleteTeamDto dto)
        {
            var team = _teamrepository.GetTeams().FirstOrDefault(_ => _.Id == dto.Id);
            if (team == null)
            {
                throw new Exception("team not found");
            }
            _teamrepository.Delete(team);
            await _unitofwork.Complete();

        }

        public List<GetTeamDto> GetTeams( FilterTeamDto dto)
        {
            var teams = _teamrepository.GetTeams().Select(_ => new GetTeamDto
            {
                Id = _.Id,
                Name = _.Name,
                FirstKit = _.FirstKit,
                SecondKit = _.SecondKit
            })
                .ToList();
            if (dto.Name != null)
            {
                teams = teams.Where(_ => _.Name == dto.Name).ToList();
                return teams;
            }
            if (dto.FirstKit != null)
            {
                teams = (List<GetTeamDto>)teams.Where(_ => _.FirstKit == dto.FirstKit).ToList();
                return teams;

            }
            return teams;
        }

        public async Task Update(int id,UpdateTeamDto dto)
        {
            var team = _teamrepository.GetTeams().FirstOrDefault(_ => _.Id == id);
            if (team == null)
            {
                throw new Exception("team not found");
            }
            team.Name = dto.Name;
            team.FirstKit = dto.FirstKit;
            team.SecondKit = dto.SecondKit;
            var result = _teamrepository.GetTeams().Any(_ => _.Name == dto.Name && _.Id!=id);
            if (result == true)
            {
                throw new Exception("wrong team name");
            }
           await _unitofwork.Complete();
        }
    }
}
