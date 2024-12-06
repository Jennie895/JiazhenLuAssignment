namespace JiazhenAssignment;

public class PracticeNum
{
    public void UnderstandingTypes()
    {
        string[] types = { "sbyte","byte","short","ushort","int", "uint",
            "long","ulong","float","double", "decimal" };
        int[] bytes = { 1, 1, 2, 2, 4, 4, 8, 8, 4, 8, 16 };
        string[] minimumValue = {$"{sbyte.MinValue}", $"{byte.MinValue}", $"{short.MinValue}",$"{ushort.MinValue}",
            $"{int.MinValue}", $"{uint.MinValue}",$"{long.MinValue}",$"{ulong.MinValue}",$"{float.MinValue}",
            $"{double.MinValue}",$"{decimal.MinValue}" };
        string[] maximumValue = {$"{sbyte.MaxValue}", $"{byte.MaxValue}", $"{short.MaxValue}",$"{ushort.MaxValue}",
                $"{int.MaxValue}", $"{uint.MaxValue}",$"{long.MaxValue}",$"{ulong.MaxValue}",$"{float.MaxValue}",
                $"{double.MaxValue}",$"{decimal.MaxValue}"};
        
        Console.WriteLine("The following are the types of numbers in C#: ");
        Console.WriteLine("{0,-10} {1,-10} {2,-35} {3,-30}","types","bytes","minimum value","maximum value");
        for (int i = 0; i < types.Length; i++)
        {
            Console.WriteLine("{0,-10} {1,-10} {2,-35} {3,-30}",types[i],bytes[i],minimumValue[i],maximumValue[i]);
        }

    }

    public void ConvertTime(int century)
    {
        int years = 100 * century;
        int days = (int)(years * 365.2425);
        int hours = days * 24;
        int minutes = hours * 60;
        ulong seconds = (ulong)minutes * 60;
        ulong milliseconds = seconds * 1000;
        ulong microseconds = milliseconds * 1000;
        ulong nanoseconds = microseconds * 1000;
        Console.WriteLine($"{century} century = {years} years = " +
                          $"{days} days = {hours} hours = {minutes} minutes = {seconds} seconds = " +
                          $"{milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        
    }
}