namespace JiazhenAssignment;

public class RoationInteger
{
    public static void sumRoation()
    {   
        Console.WriteLine("Enter a set of numbers:");
        string number = Console.ReadLine();
        if (string.IsNullOrEmpty(number))
        {
            throw new ArgumentNullException(nameof(number), "Number cannot be null or empty");
        }
        int[] input = number.Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine("Enter the rotation number: ");
        int k = int.Parse(Console.ReadLine());
        if (k < 0)
        {
            Console.WriteLine("Invalid rotation number");
        }
        int n =input.Length;
        int[][] matrix = new int[k + 1][];
        int[] sum = new int[n];
        for (int i = 1; i <= k; i++)
        {
            matrix[i] = new int[n];
            Console.WriteLine("rotation: " + i);
            for (int j = 0; j < n; j++)
            {
                matrix[i][j] = input[(j + (n-i)) % n];
                sum[j] += matrix[i][j];
            }
        }
        Console.WriteLine($"The sum of the number after rotation: {string.Join(", ",sum)}");
    }
}