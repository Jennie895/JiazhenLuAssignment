namespace ConsoleApp3;

public interface IPersonService
{
    int CalculateAge();
    decimal CalculateSalary();
}

public abstract class Person : IPersonService
{
    public Person(string name,DateTime dateOfBirth)
    {
        Name = name;
        DateOfBirth = dateOfBirth;
        Addresses = new List<string>();
    }    
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public List<string> Addresses { get; set; }

    public int CalculateAge()
    {
        DateTime current = DateTime.Now;
        return current.Year - DateOfBirth.Year;
    }

    public abstract decimal CalculateSalary();
}