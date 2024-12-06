namespace JiazhenAssignment;

public class UniquePalindrome
{
    public static void PrintUniquePalindrome()
    {
        Console.WriteLine("Enter a text:");
        string input = Console.ReadLine();
        string[] words = input.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '-', '\n', '\r' }, 
            StringSplitOptions.RemoveEmptyEntries);
        HashSet<string> palindromes = new HashSet<string>();
        foreach (var word in words)
        {
            if (IsPalindrome(word))
            {
                palindromes.Add(word);
            }
        }
        List<string> uniquePalindromes = palindromes.OrderBy(x => x).ToList();
        Console.WriteLine("Unique Palindromes:");
        Console.WriteLine(string.Join(", ", uniquePalindromes));
    }
    static bool IsPalindrome(string word)
    {
        int left = 0, right = word.Length - 1;
        while (left < right)
        {
            if (word[left] != word[right]) { return false;}
            left++;
            right--;
        }

        return true; 
    }
    
}