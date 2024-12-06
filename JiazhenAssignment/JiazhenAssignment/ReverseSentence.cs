using System.Text;
using System.Text.RegularExpressions;

namespace JiazhenAssignment;

public class ReverseSentence
{
    public static void Reverse()
    {
        Console.WriteLine("input a sentence: ");
        string input = Console.ReadLine();
        string pattern = @"[a-zA-Z0-9\+\-\*/=#]+|[.,:;=\(\)&\[\]\""\']/|\s+|[!?]";
        List<string>parts = new List<string>();
        foreach (Match match in Regex.Matches(input, pattern))
        {
            parts.Add(match.Value);
        }
        List<string> words = new List<string>();
        foreach (var part in parts)
        {
            if (!IsSeparator(part))
            {
                words.Add(part); 
            }
        }
        words.Reverse();
        StringBuilder result = new StringBuilder();
        int wordIndex = 0;
        foreach (var part in parts)
        {
            if (IsSeparator(part))
            {
                result.Append(part); // Add separators as they are
            }
            else
            {
                result.Append(words[wordIndex]); // Add reversed words
                wordIndex++;
            }
        }

        Console.WriteLine(result.ToString());
    }
    static bool IsSeparator(string part)
    {
        // Define the valid separators using a regex
        return Regex.IsMatch(part, @"[.,:;=\(\)&\[\]\""\']/|\s+|[!?]");
    }
    
       
}