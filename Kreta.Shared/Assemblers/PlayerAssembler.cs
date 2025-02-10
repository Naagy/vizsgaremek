using Real.Shared.Dtos;
using Real.Shared.Extensions;
using Real.Shared.Models;

namespace Real.Shared.Assemblers
{
    public class PlayerAssembler : Assambler<Player, PlayerDto>
    {
        public override PlayerDto ToDto(Player domainEntity)
        {
            return domainEntity.ToPlayerDto();
        }

        public override Player ToModel(PlayerDto dto)
        {
            return dto.ToPlayer();
        }
    }
}
