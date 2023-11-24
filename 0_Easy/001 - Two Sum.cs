namespace Easy;

public class _001___Two_Sum
{
    public static int[] TwoSum(int[] nums, int target)
    {
        List<int> numList = nums.ToList();
        for (int i = 0; i < nums.Length; i++)
        {
            int compliment = target - nums[i];
            if (numList.Contains(compliment) && numList.IndexOf(compliment) != i)
            {
                return new int[] { i, numList.IndexOf(compliment) };
            }
        }
        throw new Exception("No Solution exists");
    }
    public static int[] TwoSum_2(int[] nums, int target)
    {
        // key: index of number in array nums
        // value: target - num
        Dictionary<int, int> numComplement = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            // i.e. the complement exists in the dictionary
            if (numComplement.ContainsKey(nums[i]))
            {
                return new int[] { numComplement[nums[i]], i };
            }
            // Add the complement as a key and the index as a value
            else
            {
                numComplement[target - nums[i]] = i;
            }
        }
        return new int[] { };
    }


}
