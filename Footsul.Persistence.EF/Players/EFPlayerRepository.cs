using Footsul.Entities;
using Footsul.Services.Players.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footsul.Persistence.EF.Players
{
    public class EFPlayerRepository : PlayerRepository
    {
        private readonly EFDataContext _context;
        public EFPlayerRepository(EFDataContext context)
        {
            _context = context;
        }
        public void Add(Player player)
        {
            _context.Players.Add(player);
        }

        public void Delete(Player player)
        {
            _context.Players.Remove(player);
        }

        public List<Player> GetPlayers()
        {
            return _context.Players.ToList();
        }

        public void Update()
        {
            
        }
    }
}
