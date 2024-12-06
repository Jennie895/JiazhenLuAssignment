namespace JiazhenAssignment;

public class LongestEqualElement
{
    public static int[] FindLongest(int[] number)
    {
        int maxLength = 0;
        int left = 0;
        int currentLength = 1;
        for (int i = 1; i < number.Length; i++)
        {
            if (number[i] == number[i - 1])
            {
                currentLength++;
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    left = i - currentLength+1;
                }
            }
            else
            {
                currentLength = 1;
            }
        }

        int[] result = new int[maxLength];
        Array.Copy(number,left,result,0,maxLength);
        return result;
    }
}