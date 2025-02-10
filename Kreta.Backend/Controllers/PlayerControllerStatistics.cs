using Real.Backend.Controllers.Base;
using Real.Shared.Dtos;
using Real.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Real.Backend.Controllers
{
    public partial class PlayerController : BaseController<Player, PlayerDto>
    {
        [HttpGet("NumberOfPlayer")]
        public async Task<IActionResult> GetNumberOfPlayer()
        {
            return Ok(await _playerRepo.GetNumberOfPlayerAsync());
        }
    }
}
