namespace Kupri4.UnitOfWorkLesson.ConsoleApp.ViewModels;

public class PetWithPersonViewModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public Guid PersonId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
}