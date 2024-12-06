namespace ConsoleApp3;

public interface CourseService
{
    
}
public class Course
{
    public Course(string courseName, double credits)
    {
        CourseName = courseName;
        Credits = credits;
        StudentsList = new List<Student>();
    }
    public string CourseName{get;set;}
    public double Credits{get;set;}
    public List<Student> StudentsList{ get; set; }
    
}