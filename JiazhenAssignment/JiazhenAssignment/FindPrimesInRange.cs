using System.Collections;

namespace JiazhenAssignment;

public class FindPrimesInRange
{
    static bool isPrime( int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;
        for(int i =3;i<= Math.Sqrt(number);i++)
        {
            if(number % i == 0) return false;
        }
        return true;
    }
    public static int[] findPrimesInRange( int startNum, int endNum)
    {   
        List<int> primes = new List<int>();
        for (int i = startNum; i <= endNum; i++)
        {
            if (isPrime(i))
            {
                primes.Add(i);
            }
        }
        return primes.ToArray();
    }
    
}