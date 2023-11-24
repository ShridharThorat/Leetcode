namespace Medium;

public class _003_
{
    public int LengthOfLongestSubstring(string s)
    {
        Queue<char> currentSubString = new Queue<char>();
        int i = 0;
        int max = 0;
        while (i < s.Length)
        {
            if (currentSubString.Contains(s[i]) == false)
            {
                currentSubString.Enqueue(s[i]);
                i++;
            }
            else
            {
                max = Math.Max(max, currentSubString.Count);
                // Remove the first char, i.e. the one we found a duplicate for
                currentSubString.Dequeue();
            }


        }
        max = Math.Max(max, currentSubString.Count);
        return max;
    }
}
