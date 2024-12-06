// See https://aka.ms/new-console-template for more information
//=============Working with methods==========

//--------1-----------

using ConsoleApp3;

int[] numbers = ReverseNum.GenerateNumbers(8);
Console.WriteLine("Numbers:");
Console.WriteLine(string.Join(", ", numbers));
ReverseNum.Reverse(numbers);
ReverseNum.PrintNumbers(numbers);


//---------2------------
//get the 6th element.
int element = Fibonacci.GetFibonacci(6);
Console.WriteLine(element);

//===================================
//demo of project
Instructor john = new Instructor("John Smith",new DateTime(1960/4/2),new DateTime(1996/5/2));
Instructor fred = new Instructor("Fred Jones",new DateTime(1970/6/22),new DateTime(2000/7/22));
Department math = new Department("Mathematics", john);
Student max = new Student("Max Cooper", new DateTime(2000, 2, 3));
Student laura = new Student("Laura Jones", new DateTime(1999, 12, 2));
Course calcules = new Course("Calculus",5.0d);
Course statistics = new Course("Statistics", 4.0d);
math.Courses.Add(calcules);
math.Courses.Add(statistics);
max.Grade.Add(calcules,'B');
max.Grade.Add(statistics,'A');
laura.Grade.Add(calcules,'A');

Console.WriteLine($"{max.Name}'s age is {max.CalculateAge()}, and {john.Name}'s age is {john.CalculateAge()}");
Console.WriteLine($"The head of {math.Name} department is {math.HeadOfDepartment.Name}");
Console.WriteLine($"Instructors {john.Name} has a {john.CalculateSalary()} Salary, {fred.Name} has a {fred.CalculateSalary()} Salary");
Console.WriteLine($"{max.Name} GPA is {max.CalculateGPA()},{laura.Name} GPA is {laura.CalculateGPA()}");






