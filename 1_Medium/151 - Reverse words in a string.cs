namespace Medium;

public class _151_
{
    public static string ReverseWords(string s)
    {
        // O(n) runtime and memory -> n is number of words
        string[] list_s = s.Split(" ");


        return s;
    }

    public static void Main()
    {
        string s = "the sky is blue";
        string output = _151_.ReverseWords(s);
        Console.WriteLine(output);

        s = "  hello world  ";

        s = "a good   example";
    }
}
