using Real.Shared.Enums;
using Real.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Real.Backend.Context
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<Player> players = new List<Player>
    {
        new Player
        {
            Id = Guid.NewGuid(),
            FirstName = "Thibaut",
            LastName = "Courtois",
            BirthsDay = new DateTime(1992, 5, 11),
            RealYear = 2026, // Szerződés lejárata
            RealClass = RealClassType.ClassA,
            PlayerPosition = "kapus",
            IsWoman = false,
        },
        new Player
        {
            Id = Guid.NewGuid(),
            FirstName = "Andriy",
            LastName = "Lunin",
            BirthsDay = new DateTime(1998, 2, 11),
            RealYear = 2030, // Szerződés lejárata
            RealClass = RealClassType.ClassA,
            PlayerPosition = "kapus",
            IsWoman = false,
        },
        new Player
        {
            Id = Guid.NewGuid(),
            FirstName = "Éder",
            LastName = "Militão",
            BirthsDay = new DateTime(1998, 1, 18),
            RealYear = 2028, // Szerződés lejárata
            RealClass = RealClassType.ClassA,
            PlayerPosition = "védő",
            IsWoman = false,
        },
        new Player
        {
            Id = Guid.NewGuid(),
            FirstName = "Antonio",
            LastName = "Rüdiger",
            BirthsDay = new DateTime(1993, 3, 3),
            RealYear = 2026, // Szerződés lejárata
            RealClass = RealClassType.ClassA,
            PlayerPosition = "védő",
            IsWoman = false,
        },
        new Player
        {
            Id = Guid.NewGuid(),
            FirstName = "David",
            LastName = "Alaba",
            BirthsDay = new DateTime(1992, 6, 24),
            RealYear = 2026, // Szerződés lejárata
            RealClass = RealClassType.ClassA,
            PlayerPosition = "védő",
            IsWoman = false,
        },
        new Player
        {
            Id = Guid.NewGuid(),
            FirstName = "Raúl",
            LastName = "Asencio",
            BirthsDay = new DateTime(2002, 2, 21),
            RealYear = 2026, // Szerződés lejárata
            RealClass = RealClassType.ClassB,
            PlayerPosition = "védő",
            IsWoman = false,
        },
        new Player
        {
            Id = Guid.NewGuid(),
            FirstName = "Jesús",
            LastName = "Vallejo",
            BirthsDay = new DateTime(1997, 1, 5),
            RealYear = 2025, // Szerződés lejárata
            RealClass = RealClassType.ClassA,
            PlayerPosition = "védő",
            IsWoman = false,
        },
        new Player
        {
            Id = Guid.NewGuid(),
            FirstName = "Ferland",
            LastName = "Mendy",
            BirthsDay = new DateTime(1995, 6, 8),
            RealYear = 2028, // Szerződés lejárata
            RealClass = RealClassType.ClassA,
            PlayerPosition = "védő",
            IsWoman = false,
        },
        new Player
        {
            Id = Guid.NewGuid(),
            FirstName = "Fran",
            LastName = "García",
            BirthsDay = new DateTime(1998, 8, 9),
            RealYear = 2027, // Szerződés lejárata
            RealClass = RealClassType.ClassA,
            PlayerPosition = "védő",
            IsWoman = false,
        },
        new Player
        {
            Id = Guid.NewGuid(),
            FirstName = "Daniel",
            LastName = "Carvajal",
            BirthsDay = new DateTime(1992, 1, 11),
            RealYear = 2026, // Szerződés lejárata
            RealClass = RealClassType.ClassA,
            PlayerPosition = "védő",
            IsWoman = false,
        },
        new Player
        {
            Id = Guid.NewGuid(),
            FirstName = "Lucas",
            LastName = "Vázquez",
            BirthsDay = new DateTime(1991, 7, 1),
            RealYear = 2025, // Szerződés lejárata
            RealClass = RealClassType.ClassA,
            PlayerPosition = "védő",
            IsWoman = false,
        },
        new Player
        {
            Id = Guid.NewGuid(),
            FirstName = "Aurélien",
            LastName = "Tchouaméni",
            BirthsDay = new DateTime(2000, 1, 27),
            RealYear = 2028, // Szerződés lejárata
            RealClass = RealClassType.ClassA,
            PlayerPosition = "középpályás",
            IsWoman = false,
        },
        new Player
        {
            Id = Guid.NewGuid(),
            FirstName = "Federico",
            LastName = "Valverde",
            BirthsDay = new DateTime(1998, 7, 22),
            RealYear = 2029, // Szerződés lejárata
            RealClass = RealClassType.ClassA,
            PlayerPosition = "középpályás",
            IsWoman = false,
        },
        new Player
        {
            Id = Guid.NewGuid(),
            FirstName = "Eduardo",
            LastName = "Camavinga",
            BirthsDay = new DateTime(2002, 11, 10),
            RealYear = 2029, // Szerződés lejárata
            RealClass = RealClassType.ClassA,
            PlayerPosition = "középpályás",
            IsWoman = false,
        },
        new Player
        {
            Id = Guid.NewGuid(),
            FirstName = "Luka",
            LastName = "Modric",
            BirthsDay = new DateTime(1985, 9, 9),
            RealYear = 2025, // Szerződés lejárata
            RealClass = RealClassType.ClassA,
            PlayerPosition = "középpályás",
            IsWoman = false,
        },
        new Player
        {
            Id = Guid.NewGuid(),
            FirstName = "Dani",
            LastName = "Ceballos",
            BirthsDay = new DateTime(1996, 8, 7),
            RealYear = 2027, // Szerződés lejárata
            RealClass = RealClassType.ClassA,
            PlayerPosition = "középpályás",
            IsWoman = false,
        },
        new Player
        {
            Id = Guid.NewGuid(),
            FirstName = "Jude",
            LastName = "Bellingham",
            BirthsDay = new DateTime(2003, 6, 29),
            RealYear = 2029, // Szerződés lejárata
            RealClass = RealClassType.ClassA,
            PlayerPosition = "középpályás",
            IsWoman = false,
        },
        new Player
        {
            Id = Guid.NewGuid(),
            FirstName = "Vinicius",
            LastName = "Junior",
            BirthsDay = new DateTime(2000, 7, 12),
            RealYear = 2027, // Szerződés lejárata
            RealClass = RealClassType.ClassA,
            PlayerPosition = "támadó",
            IsWoman = false,
        },
        new Player
        {
            Id = Guid.NewGuid(),
            FirstName = "Rodrygo",
            LastName = "Goes",
            BirthsDay = new DateTime(2001, 1, 9),
            RealYear = 2028, // Szerződés lejárata
            RealClass = RealClassType.ClassA,
            PlayerPosition = "támadó",
            IsWoman = false,
        },
        new Player
        {
            Id = Guid.NewGuid(),
            FirstName = "Arda",
            LastName = "Güler",
            BirthsDay = new DateTime(2005, 8, 25),
            RealYear = 2029, // Szerződés lejárata
            RealClass = RealClassType.ClassA,
            PlayerPosition = "támadó",
            IsWoman = false,
        },
        new Player
        {
            Id = Guid.NewGuid(),
            FirstName = "Brahim",
            LastName = "Díaz",
            BirthsDay = new DateTime(1999, 8, 3),
            RealYear = 2027, // Szerződés lejárata
            RealClass = RealClassType.ClassA,
            PlayerPosition = "támadó",
            IsWoman = false,
        },
        new Player
        {
            Id = Guid.NewGuid(),
            FirstName = "Kylian",
            LastName = "Mbappé",
            BirthsDay = new DateTime(1998, 12, 20),
            RealYear = 2029, // Szerződés lejárata
            RealClass = RealClassType.ClassA,
            PlayerPosition = "támadó",
            IsWoman = false,
        },
        new Player
        {
            Id = Guid.NewGuid(),
            FirstName = "Endrick",
            LastName = "Felipe",
            BirthsDay = new DateTime(2006, 7, 21),
            RealYear = 2030, // Szerződés lejárata
            RealClass = RealClassType.ClassA,
            PlayerPosition = "támadó",
            IsWoman = false,
        }
    };

            // Players
            modelBuilder.Entity<Player>().HasData(players);
        }

    }
}
