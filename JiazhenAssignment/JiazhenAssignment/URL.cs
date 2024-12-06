namespace JiazhenAssignment;

public class URL
{
    public static void PrintURL()
    {
        Console.WriteLine("URL:");
        string input = Console.ReadLine();
        int firstIndex = 0;
        int secondIndex = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '/' && input[i + 1] == '/')
            {
                firstIndex = i;
            }else if (input[i] == '/')
            {
                secondIndex = i;
            }
        }
        string protocol = input.Substring(0,firstIndex);
        string server = "";
        if (firstIndex == 0 && secondIndex == 0)
        {
            server = input;
        }else if (firstIndex != 0 && secondIndex == 0)
        {
            server = input.Substring(firstIndex+2,input.Length-firstIndex-2);
        }
        else
        {
            server = input.Substring(firstIndex+2,secondIndex-firstIndex-2);
        }
        string resource = input.Substring(secondIndex+1,input.Length-secondIndex-1);
        Console.WriteLine($"Protocol: {protocol}");
        Console.WriteLine($"Server: {server}");
        Console.WriteLine($"Resource: {resource}");
    }
}