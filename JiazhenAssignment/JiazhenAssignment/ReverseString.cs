namespace JiazhenAssignment;

public class ReverseString
{
    public static void ReverseStringWithArray()
    {
        Console.WriteLine("type a string");
        string input = Console.ReadLine();
        char[] arr = input.ToArray();
        Array.Reverse(arr);
        string output = new string(arr);
        Console.WriteLine(output);
    }

    public static void PrintStringBackwards()
    {
        Console.WriteLine("type a string");
        string input = Console.ReadLine();
        for(int i =input.Length-1;i>=0;i--)
        Console.Write(input[i]);
    }
}