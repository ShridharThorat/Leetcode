namespace Easy;

public class _0013_
{
    public static int RomanToInt(string s)
    {
        if (ValidLength(s))
        {
            if (ValidRoman(s))
            {
                return CalculateInt(s);
            }
            else { return 0; }
        }
        Console.WriteLine("Length should be between 1 and 15 inclusive");
        return 0;
    }

    private static bool ValidLength(string s)
    {
        if (s.Length >= 1 && s.Length <= 15) { return true; }
        else { return false; }
    }

    private static bool ValidRoman(string s)
    {
        string[] choices = new string[] { "I", "V", "X", "L", "C", "D", "M" };
        foreach (char character in s)
        {
            if (Array.IndexOf(choices, character) > -1)
            {
                Console.WriteLine($"The numeral '{s}' contains an invalid character");
                return false;
            }
        }
        return true;
    }

    private static int CalculateInt(string s)
    {
        int total = 0;
        for (int i = 0; i <= s.Length - 1; i++)
        {
            char character = s[i];
            switch (character)
            {
                case 'I':
                    if (s.Length - 1 != i)
                    {
                        if (s[i + 1] == 'V')
                        {
                            total += 4;
                            i++;
                            break;
                        }
                        else if (s[i + 1] == 'X')
                        {
                            total += 9;
                            i++;
                            break;
                        }
                    }
                    total += 1;
                    break;
                case 'V': total += 5; break;
                case 'X':
                    if (s.Length - 1 != i)
                    {
                        if (s[i + 1] == 'L')
                        {
                            total += 40;
                            i++;
                            break;
                        }
                        else if (s[i + 1] == 'C')
                        {
                            total += 90;
                            i++;
                            break;
                        }
                    }
                    total += 10;
                    break;
                case 'L': total += 50; break;
                case 'C':
                    if (s.Length - 1 != i)
                    {
                        if (s[i + 1] == 'D')
                        {
                            total += 400;
                            i++;
                            break;
                        }
                        else if (s[i + 1] == 'M')
                        {
                            total += 900;
                            i++;
                            break;
                        }
                    }
                    total += 100;
                    break;
                case 'D': total += 500; break;
                case 'M': total += 1000; break;
                default: throw new InvalidOperationException("Roman character is invalid"); ; // technically wouldn't reach
            }
        }
        return total;
    }
}
