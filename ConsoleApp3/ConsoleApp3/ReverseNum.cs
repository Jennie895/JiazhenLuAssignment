namespace ConsoleApp3;

public class ReverseNum
{
    public static int[] GenerateNumbers(int length)
    {
        int[] result = new int[length];
        Random random = new Random();
        for (int i = 0; i < length; i++)
        {
            result[i] = random.Next(0,1000);
        }
        return result;
        
    }

    public static void Reverse(int[] numbers)
    {
        int left = 0;
        int right = numbers.Length - 1;
        while (left < right)
        {
            int temp = numbers[left];
            numbers[left]= numbers[right];
            numbers[right] = temp;
            left++;
            right--;
        }
    }

    public static void PrintNumbers(int[] numbers)
    {
        Console.WriteLine(string.Join(", ",numbers));
    }
}