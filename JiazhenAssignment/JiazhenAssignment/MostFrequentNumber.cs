namespace JiazhenAssignment;

public class MostFrequentNumber
{
    public static void GetMostFrequentNumber()
    {
        Console.WriteLine("type a set of numbers");
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
            throw new FormatException("invalid input");
        }
        int[] numbers = input.Split(" ").Select(int.Parse).ToArray();
        Dictionary<int, int> counts = new Dictionary<int, int>();
        for (int i = 0; i < numbers.Length; i++)
        { 
            counts[numbers[i]] = counts.GetValueOrDefault(i,0)+1;
        }

        int result = numbers[0];
        int maxCount = 1;
        for (int i=0;i<numbers.Length; i++)
        {
            if (counts[numbers[i]] > maxCount)
            {
                maxCount = counts[numbers[i]];
                result = numbers[i];
            }
        }
        Console.WriteLine($"The leftmost of the most frequency number is {result}" );

    }
    
}