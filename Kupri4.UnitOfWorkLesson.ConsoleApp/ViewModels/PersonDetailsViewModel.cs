namespace Kupri4.UnitOfWorkLesson.ConsoleApp.ViewModels;

public class PersonDetailsViewModel
{
    public Guid Id { get; set; }
    public DateOnly BirthDate { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public int AdressesCount { get; set; }
    public int PetsCount { get; set; }

    public virtual ICollection<AddressViewModel>? Adresses { get; set; }
    public virtual ICollection<PetViewModel>? Pets { get; set; }
}


