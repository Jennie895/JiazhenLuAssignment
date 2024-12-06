namespace JiazhenAssignment;

public class PracticeLoops
{
    public void FizzBuzzis(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            } else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }else
            {
                Console.WriteLine(i);
            }
        }
    }

    public void GuessNumber()
    {
        int correctNumber = new Random().Next(3) + 1;
        Console.WriteLine("Guess a number between 1 and 3");
        int guess = int.Parse(Console.ReadLine());
        while (guess != correctNumber)
        {
            if (guess>3 || guess<1)
            {
                Console.WriteLine("Please enter a number between 1 and 3");
                guess = int.Parse(Console.ReadLine());
            }
            else if (guess < correctNumber)
            {
                Console.WriteLine("Too low, try again.");
                guess = int.Parse(Console.ReadLine());
            }
            else if (guess > correctNumber)
            {
                Console.WriteLine("Too high, try again.");
                guess = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Your guess is right!");
    }

    public void PrintAPyramid(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    
    public void DaysOfBrith(DateTime birthDate)
    {
        DateTime today = DateTime.Today;
        int days = today.Subtract(birthDate).Days;
        Console.WriteLine($"You are {days} days old.");
        int daysToNextAnniversary = 10000 - (days % 10000);
        Console.WriteLine($"There are {daysToNextAnniversary} days to your next anniversary.");
        
    }

    public void Greeting(DateTime currentTime)
    {
        TimeSpan morningTime = new TimeSpan(6, 0, 0);
        TimeSpan afterNoonTime = new TimeSpan(11, 0, 0);
        TimeSpan eveningTime = new TimeSpan(17, 0, 0);
        TimeSpan nightTime = new TimeSpan(21, 0, 0);
        if (currentTime.TimeOfDay >= morningTime && currentTime.TimeOfDay <= afterNoonTime)
        {
            Console.WriteLine("Good Morning!");
        }

        if (currentTime.TimeOfDay >= afterNoonTime && currentTime.TimeOfDay <= eveningTime)
        {
            Console.WriteLine("Good Afternoon!");
        }

        if (currentTime.TimeOfDay >= eveningTime && currentTime.TimeOfDay <= nightTime)
        {
            Console.WriteLine("Good Evening!");
        }

        if (currentTime.TimeOfDay >= nightTime)
        {
            Console.WriteLine("Good Night!");
        }
    }

    public void Counting24()
    {
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 0; j <= 24; j = j + i)
            {
                if (j == 24)
                {
                    Console.Write(j);
                }else Console.Write($"{j}, ");
            }
            Console.WriteLine();
        }
    }
}