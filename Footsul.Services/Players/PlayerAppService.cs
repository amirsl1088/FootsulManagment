using Footsul.Entities;
using Footsul.Services.Players.Contracts;
using Footsul.Services.Players.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taav.Contracts;

namespace Footsul.Services.Players
{
    public class PlayerAppService : PlayerService
    {
        private readonly PlayerRepository _playerrepository;
        private readonly IUnitOfWork _unitOfWork;
        public PlayerAppService(PlayerRepository playerRepository,IUnitOfWork unitOfWork)
        {
            _playerrepository = playerRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task Add(AddPlayerDto dto)
        {
            var player = new Player
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                BirthDay = dto.BirthDay
            };
            _playerrepository.Add(player);
            await _unitOfWork.Complete();
        }

      
    }
}
