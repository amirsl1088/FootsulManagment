using Footsul.Services.Teams.Contracts;
using Footsul.Services.Teams.Contracts.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace Footsul.RestApi.Controllers
{
    [Route("api/Teams")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly TeamService _service;
        public TeamController(TeamService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task Add(AddTeamDto dto)
        {
           await _service.Add(dto);
        }
        [HttpGet]
        public List<GetTeamDto> GetTeams([FromQuery]FilterTeamDto dto)
        {
            return _service.GetTeams(dto);
        }
        [HttpPut]
        public async Task Update([FromQuery]int id,[FromBody]UpdateTeamDto dto)
        {
            await _service.Update(id, dto);
        }
        [HttpDelete]
        public async Task Delete(DeleteTeamDto dto)
        {
            await _service.Delete(dto);
        }

    }
}
