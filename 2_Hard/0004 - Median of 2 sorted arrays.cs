namespace Hard;

public class _0004_
{
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int totalLength = nums1.Length + nums2.Length;
        int medIndex = totalLength / 2;
        List<int> merged = new List<int>();
        for (int i = 0; i < medIndex + 1; i++)
        {
            if (i <= nums1.Length - 1) { merged.Add(nums1[i]); }
            if (i <= nums2.Length - 1) { merged.Add(nums2[i]); }
        }
        merged.Sort();
        if (totalLength % 2 == 0) { return (double)(merged[medIndex] + merged[medIndex - 1]) / 2; }
        else { return (double)merged[medIndex]; }
    }
}
