namespace Kupri4.UnitOfWorkLesson.ConsoleApp.ViewModels;

public class AddressWithPerson
{
    public Guid PersonId { get; set; }
    public DateTime BirthDate { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }

    public Guid Id { get; set; }
    public bool IsDefault { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public string Building { get; set; }
    public string Flat { get; set; }
}
