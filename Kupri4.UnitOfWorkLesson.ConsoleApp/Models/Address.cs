namespace Kupri4.UnitOfWorkLesson.ConsoleApp.Models;

public class Address
{
    public Guid Id { get; set; }
    public bool IsDefault { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public string Building { get; set; }
    public string Flat { get; set; }
    public string Street { get; set; }

    public Person Person { get; set; }
}
