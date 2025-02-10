using Real.Shared.Enums;

namespace Real.Shared.Dtos
{
    public class PlayerDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthsDay { get; set; }
        public int RealYear { get; set; }
        public RealClassType RealClass { get; set; }
        public string PlayerPosition { get; set; }

        public PlayerDto(Guid id, string firstName, string lastName, DateTime birthsDay, int realYear, RealClassType realClass, string playerPosition)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthsDay = birthsDay;
            RealYear = realYear;
            RealClass = realClass;
            PlayerPosition = playerPosition;
        }

        public PlayerDto()
        {
            Id = Guid.NewGuid();
            FirstName = string.Empty;
            LastName = string.Empty;
            BirthsDay = new DateTime();
            RealYear = 2025;
            RealClass = RealClassType.ClassA;
            PlayerPosition = string.Empty;
        }
    }
}
