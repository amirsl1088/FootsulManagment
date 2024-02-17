using Footsul.Services.Players.Contracts;
using Footsul.Services.Players.Contracts.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Footsul.RestApi.Controllers
{
    [Route("api/Players")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly PlayerService _service;
        public PlayerController(PlayerService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task Add([FromBody]AddPlayerDto dto)
        {
            await _service.Add(dto);
        }
        [HttpGet]
        public List<GetPlayerDto> GetPlayers([FromQuery]FilterGetDto dto)
        {
            return _service.GetPlayers(dto);
        }
        [HttpPut]
        public async Task Update([FromQuery]int id,[FromBody] UpdatePlayerDto dto)
        {
            await _service.Update(id, dto);
        }
        [HttpDelete]
        public async Task Delete([FromQuery]DeletePlayerDto dto)
        {
            await _service.Delete(dto);
        }
    }
}
