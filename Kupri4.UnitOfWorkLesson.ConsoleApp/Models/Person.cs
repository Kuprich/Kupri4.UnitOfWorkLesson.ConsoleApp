namespace Kupri4.UnitOfWorkLesson.ConsoleApp.Models;
public class Person
{
    public Guid Id { get; set; }
    public DateTime BirthDate { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }

    public virtual IList<Address> Adresses { get; set; } = new List<Address>();
    public virtual IList<Pet> Pets { get; set; } = new List<Pet>();
}
