namespace Medium;

public class _1685_
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="nums">Is a sorted array in non-decreasing order</param>
    /// <returns></returns>
    public static int[] GetSumAbsoluteDifferences(int[] nums)
    {
        int[] result = new int[nums.Length];
        Array.Copy(nums,result,nums.Length);
        int j = 0;
        for(int i=0; i<nums.Length;i++)
        {
            if (result[j] != nums[i])
            {
                result[j] = Math.Max(result[j],nums[i]) - Math.Min(result[j],nums[i]);
            }
            j++;
        }
        return result;
    }
    public static int[] GetSumAbsoluteDifferences(bool BruteForce, int[] nums)
    {
        int i = 0;
        int[] result = new int[nums.Length];
        foreach (int num in nums)
        {
            result[i] = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                result[i] += Math.Abs(nums[i] - nums[j]);
            }
            i++;
        }

        return result;
    }

    public static void Main()
    {
        // [ 1 2 3 4 5 6 7 ]
        // [ 21 16 13 12 13 16 21 ]
        int[] nums = new int[] { 2,3,5 };
        Console.Write("[ ");
        foreach (int i in nums)
        {
            Console.Write($"{i} ");
        }
        Console.Write("]\n");


        int[] output = GetSumAbsoluteDifferences(nums);
        Console.Write("[ ");
        foreach (int i in output)
        {
            Console.Write($"{i} ");
        }
        Console.Write("]\n");

    }
}
