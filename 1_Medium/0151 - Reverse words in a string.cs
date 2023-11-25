namespace Medium;

public class _0151_
{
    /// <summary>
    /// Runtime: 109ms
    /// Memory:  119mb
    /// </summary>
    /// <param name="s">A sentence of type; string</param>
    /// <returns>A reversed sentence with trimed whitespace</returns>
    public static string ReverseWords(string s)
    {
        string reverse = "";   
        while (s.Length > 0)
        {
            int whiteSpace = s.LastIndexOf(" ");
            if(whiteSpace == -1)
            {
                whiteSpace = 0;
            }
            string lastWord = s[whiteSpace..];
            reverse = reverse.Trim() + " " + lastWord.Trim();
            s = s.Remove(whiteSpace);
        }
        return reverse.Trim();
    }

    /// <summary>
    /// Runtime: 69ms
    /// Memory:  38.8mb
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static string ReverseWords_Efficient(string s)
    {
        return string.Join(" ", s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse());
    }

    // public static void Main()
    // {
    //     string s = "the sky is blue    ";
    //     string output = _0151_.ReverseWords(s);
    //     Console.WriteLine(output);

    //     s = "  hello       world  ";
    //     output = _0151_.ReverseWords(s);
    //     Console.WriteLine(output);

    //     s = "EPY2giL";
    //     output = _0151_.ReverseWords(s);
    //     Console.WriteLine(output);
    // }
}
