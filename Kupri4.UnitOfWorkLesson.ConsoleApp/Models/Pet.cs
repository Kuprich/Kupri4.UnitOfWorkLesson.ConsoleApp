namespace Kupri4.UnitOfWorkLesson.ConsoleApp.Models;

public class Pet
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Person Person { get; set; }
}
