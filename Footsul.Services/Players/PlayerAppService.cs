using Footsul.Entities;
using Footsul.Services.Players.Contracts;
using Footsul.Services.Players.Contracts.Dtos;
using Footsul.Services.Teams.Contracts;
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

        public async Task Delete(DeletePlayerDto dto)
        {
            var player = _playerrepository.GetPlayers().FirstOrDefault(_ => _.Id == dto.Id);
            if (player == null)
            {
                throw new Exception("player not found");
            }
            _playerrepository.Delete(player);
            await _unitOfWork.Complete();
        }

        public List<GetPlayerDto> GetPlayers(FilterGetDto dto)
        {
            var players = _playerrepository.GetPlayers().Select(_ => new GetPlayerDto
            {
                Id = _.Id,
                FirstName = _.FirstName,
                LastName = _.LastName,
                BirthDay = _.BirthDay
            })
                .ToList();
            if (dto.FirstName != null)
            {
                players = players.Where(_ => _.FirstName == dto.FirstName).ToList();
                return players;
            }

            return players;
        }

        public async Task Update(int id, UpdatePlayerDto dto)
        {
            var player = _playerrepository.GetPlayers().FirstOrDefault(_ => _.Id == id);
            if (player == null)
            {
                throw new Exception("wrong player");
            }
            player.FirstName = dto.FirstName;
            player.LastName = dto.LastName;
            player.BirthDay = dto.BirthDay;
            var result =_playerrepository.GetPlayers().Any(_ => _.FirstName == dto.FirstName && _.Id != id);
            if (result == true)
            {
                throw new Exception("cannot use same player name");
            }
            await _unitOfWork.Complete();

        }
    }
}
