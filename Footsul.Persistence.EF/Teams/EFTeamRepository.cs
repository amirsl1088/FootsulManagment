using Footsul.Entities;
using Footsul.Services.Teams.Contracts;
using Footsul.Services.Teams.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footsul.Persistence.EF.Teams
{
    public class EFTeamRepository : TeamRepository
    {
        private readonly EFDataContext _context;
        public EFTeamRepository(EFDataContext context)
        {
            _context = context;
        }
        public void Add(Team team)
        {
            _context.Teams.Add(team);
        }

        public void Delete(Team team)
        {
            _context.Teams.Remove(team);
        }

        public List<Team> GetTeams()
        {
            return _context.Teams.ToList();
        }

        public void Update()
        {

        }
    }
}
