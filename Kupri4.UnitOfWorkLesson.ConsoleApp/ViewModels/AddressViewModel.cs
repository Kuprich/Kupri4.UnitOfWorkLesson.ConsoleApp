namespace Kupri4.UnitOfWorkLesson.ConsoleApp.ViewModels;

public class AddressViewModel
{
    public Guid Id { get; set; }
    public bool IsDefault { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public string Building { get; set; }
    public string Flat { get; set; }
}
