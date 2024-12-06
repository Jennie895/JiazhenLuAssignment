namespace ConsoleApp3;

public class Fibonacci
{
    public static int GetFibonacci(int n)
    {
        int[] fibonacci = new int[n];
        fibonacci[0] = 1;
        fibonacci[1] = 1;
        for (int i = 2; i < n; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }
        return fibonacci[n - 1];
    }
}