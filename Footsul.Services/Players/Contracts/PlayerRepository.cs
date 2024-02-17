using Footsul.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footsul.Services.Players.Contracts
{
    public interface PlayerRepository
    {
        void Add(Player player);
        List<Player> GetPlayers();
        void Update();
        void Delete(Player player);

    }
}
