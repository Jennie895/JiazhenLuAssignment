using System.Diagnostics;

namespace ConsoleApp3;
public interface  IStudentService:IPersonService
{
    double CalculateGPA();
}
public class Student: Person, IStudentService
{
    public Student(string name, DateTime dateOfBirth) : base(name, dateOfBirth)
    {
        Grade = new Dictionary<Course, char>();
    }
    public Dictionary<Course,char> Grade{get;set;}
    public override decimal CalculateSalary()
    {   
        Console.WriteLine("Student has no salary");
        return 0m;
    }

    public double CalculateGPA()
    {
        double sumGPA = 0;
        double credits = 0;
        foreach (var item in Grade)
        {
            double gradeValue = item.Value switch
            {
                'A' => 4.0,
                'B' => 3.0,
                'C' => 2.0,
                'D' => 1.0,
                'F' => 0.0,
                _ => throw new ArgumentOutOfRangeException()
            };
            credits += item.Key.Credits;
            sumGPA+=item.Key.Credits * gradeValue;
        }

        return sumGPA / credits;
    }
}