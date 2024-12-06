using System.Text;

namespace JiazhenAssignment;

public class PlayingPart
{
    public  void Playing()
    {
        Console.WriteLine("What's your favorite color?");
        string color = Console.ReadLine();
        Console.WriteLine("What's your astrology sign?");
        string sign = Console.ReadLine();
        Console.WriteLine("What's your street address number?");
        string number = Console.ReadLine();
        StringBuilder answer = new StringBuilder();
        answer.Append(color);
        answer.Append(sign);
        answer.Append(number);
        Console.WriteLine($"Your hacker name is {answer}");
    }

}