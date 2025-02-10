using Real.Backend.Controllers.Base;
using Real.Shared.Dtos;
using Real.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Real.Backend.Controllers
{
    public partial class PlayerController : BaseController<Player, PlayerDto>
    {

        [HttpGet("getplayerbyfullname")]
        public async Task<IActionResult> GetPlayerByFullName([FromQuery] FullNameQueryDto fullNameDto)
        {
            return Ok(await _playerRepo.GetByNameAsync(fullNameDto.FirstName, fullNameDto.LastName));
        }        
    }
}
