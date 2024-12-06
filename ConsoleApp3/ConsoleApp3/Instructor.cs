namespace ConsoleApp3;

public interface IInstructorService : IPersonService
{
}
public class Instructor: Person , IInstructorService
{
    public Instructor(string name, DateTime dateOfBirth, DateTime joindate): base(name, dateOfBirth)
    {
        JoinDate = joindate;
    }
    public Department Department { get; set; }
    public DateTime JoinDate { get; set; }
    

    public bool IsHeadOfDepartment()
    {
        Instructor head = this.Department.HeadOfDepartment;
        return (head == this);
    }

    public override decimal CalculateSalary()
    {
        int years = DateTime.Now.Year - JoinDate.Year;
        decimal salary = 60000 + years * 1000M;
        return salary;
    }
    
        
}