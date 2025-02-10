using Real.Shared.Enums;

namespace Real.Shared.Models
{
    public class Player : IDbEntity<Player>
    {
        public Player(Guid id,string firstName, string lastName, DateTime birthsDay, int realYear, RealClassType realClass, string playerPosition, bool isWoman)
        {
            Id=id;
            FirstName = firstName;
            LastName = lastName;
            BirthsDay = birthsDay;
            RealYear = realYear;
            RealClass = realClass;
            PlayerPosition = playerPosition;
            IsWoman = isWoman;
        }

        public Player(string firstName, string lastName, DateTime birthsDay, int realYear, RealClassType realClass, string playerPosition,bool isWoman)
        {
            Id=Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            BirthsDay = birthsDay;
            RealYear = realYear;
            RealClass = realClass;
            PlayerPosition = playerPosition;
            IsWoman = isWoman;
        }

        public Player()
        {
            Id = Guid.NewGuid();
            FirstName = string.Empty;
            LastName = string.Empty;
            BirthsDay = new DateTime();
            RealYear = 2025;
            RealClass = RealClassType.ClassA;
            PlayerPosition = string.Empty;
            IsWoman = true;
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthsDay { get; set; }
        public int RealYear { get; set; }
        public RealClassType RealClass { get; set; }
        public bool IsWoman { get; set; }
        public bool IsMan => !IsWoman;

        public string PlayerPosition { get; set; }
        public bool HasId => Id != Guid.Empty;

        public override string ToString()
        {
            return $"{Id} {LastName} {FirstName} ({RealYear}.{RealClass}) - ({String.Format("{0:yyyy.MM.dd.}", BirthsDay)}) ({PlayerPosition})";
        }
    }
}
