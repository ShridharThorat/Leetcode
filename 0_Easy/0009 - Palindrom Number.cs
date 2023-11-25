namespace Easy;

public class _0009_
{
    public static bool IsPalindrome(int x)
    {
        if (x < 0) return false;

        string asc = x.ToString();
        char[] desArray = x.ToString().ToArray();
        Array.Reverse(desArray);
        string des = new string(desArray);
        Console.WriteLine(asc);
        Console.WriteLine(des);
        return asc.Equals(des);
    }

}
