using Footsul.Services.Players.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footsul.Services.Players.Contracts
{
    public  interface PlayerService
    {
        Task Add(AddPlayerDto dto);
    }
}
