using Real.Backend.Controllers.Base;
using Real.Backend.Repos;
using Real.Shared.Assemblers;
using Real.Shared.Dtos;
using Real.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Real.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public partial class PlayerController : BaseController<Player, PlayerDto>
    {
        private IPlayerRepo _playerRepo;
        public PlayerController(PlayerAssembler? assambler, IPlayerRepo? repo) : base(assambler, repo)
        {
            _playerRepo = repo ?? throw new ArgumentNullException(nameof(repo));
        }       
    }
}
