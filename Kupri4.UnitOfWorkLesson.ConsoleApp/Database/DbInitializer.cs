using Kupri4.UnitOfWorkLesson.ConsoleApp.Models;
using System.Globalization;

namespace Kupri4.UnitOfWorkLesson.ConsoleApp.Database;

public static class DbInitializer
{
    private static Person[] _persons = GetSomePersons();
    private static Pet[] _pets = GetSomePets();
    private static Address[] _addresses = GetSomeAddresses();

    public static async Task Initialize(ApplicationDbContext context)
    {
        context.Database.EnsureCreated();

        context.Persons.AddRange(_persons);
        context.Pets.AddRange(_pets);
        context.Address.AddRange(_addresses);

        await context.SaveChangesAsync();
    }

    private static Person[] GetSomePersons() =>
        new Person[]
        {
            new()
            {
                Id = Guid.NewGuid(),
                FirstName = "Иван",
                LastName = "Иванов",
                BirthDate = DateTime.Parse("10.02.1996", CultureInfo.InvariantCulture),
                MiddleName = "Иванович"
            },
            new()
            {
                Id = Guid.NewGuid(),
                FirstName = "Петров",
                LastName = "Петр",
                BirthDate = DateTime.Parse("10.05.1954", CultureInfo.InvariantCulture),
                MiddleName = "Петрович"
            }
        };

    private static Pet[] GetSomePets() =>
        new Pet[]
        {
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Люси",
                Description = "Собака породы бультерьер",
                Person = _persons[0]
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Чакки",
                Description = "Собака породы такса",
                Person = _persons[0]
            }
        };

    private static Address[] GetSomeAddresses() =>
        new Address[]
        {
            new()
            {
                Id = Guid.NewGuid(),
                Building = "5",
                City = "Moskow",
                Flat = "10",
                IsDefault = true,
                Name = "some address name 1 (is default)",
                Street = "Kovalenko",
                Person = _persons[0]

            },
            new()
            {
                Id = Guid.NewGuid(),
                Building = "89",
                City = "Moskow",
                Flat = "12",
                IsDefault = false,
                Name = "some address name 2 (isn't default)",
                Street = "Esenina",
                Person = _persons[0]
            },

            new()
            {
                Id = Guid.NewGuid(),
                Building = "1",
                City = "Saransk",
                Flat = "6",
                IsDefault = true,
                Name = "I love Saransk (is Default)",
                Street = "Polejaeva",
                Person = _persons[1]

            },
            new()
            {
                Id = Guid.NewGuid(),
                Building = "2",
                City = "Saransk",
                Flat = "4",
                IsDefault = false,
                Name = "some address name 2 (isn't default)",
                Street = "Ogareva",
                Person = _persons[1]
            },

        };

}

