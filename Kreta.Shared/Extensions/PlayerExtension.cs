using Real.Shared.Dtos;
using Real.Shared.Models;

namespace Real.Shared.Extensions
{
    public static class PlayerExtension
    {
        public static Dtos.PlayerDto ToPlayerDto(this Models.Player player)
        {
            return new Dtos.PlayerDto
            {
                Id= player.Id,
                FirstName = player.FirstName,
                LastName = player.LastName,
                BirthsDay = player.BirthsDay,
                RealYear = player.RealYear,
                RealClass = player.RealClass,
                PlayerPosition = player.PlayerPosition
            };
        }

        public static Models.Player ToPlayer(this Dtos.PlayerDto playerdto) 
        {
            return new Models.Player
            {
                Id = playerdto.Id,
                FirstName = playerdto.FirstName,
                LastName = playerdto.LastName,
                BirthsDay = playerdto.BirthsDay,
                RealYear = playerdto.RealYear,
                RealClass = playerdto.RealClass,
                PlayerPosition = playerdto.PlayerPosition
            };
        }
    }

}
