namespace ConsoleApp3;
public interface IDepartmentService{}
public class Department : IDepartmentService
{
    public Department(string name, Instructor head)
    {
        Name=name;
        HeadOfDepartment=head;
        Instructors = new List<Instructor>();
        Courses = new List<Course>();
        Budget = new Dictionary<Tuple<DateTime, DateTime>, decimal>();
    }
    public string Name{get;set;}
    public Instructor HeadOfDepartment{get;set;}
    public List<Instructor> Instructors{get;set;}
    public List<Course> Courses{get;set;}
    public Dictionary<Tuple<DateTime, DateTime>, decimal> Budget { get; set; }
    
}