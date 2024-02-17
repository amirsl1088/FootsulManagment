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
        public async Task Add(AddPlayerDto dto)
        {
            await _service.Add(dto);
        }
    }
}
