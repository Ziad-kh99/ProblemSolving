/*
- Probem Link: https://leetcode.com/problems/merge-sorted-array/?envType=study-plan-v2&id=top-interview-150

Time: first time it took 93min, but in vain!

*/


namespace LeetCode.Easy;

public class MergeSortedArray
{
    public static void Solution(int[] nums1, int m, int[] nums2, int n)
    {
        for(int i = 0; i < nums2.Length; ++i)
        {
            for(int j = 0; j < nums1.Length; ++j)
            {
                // if(nums1[j] == 0)
                // {
                //     nums1[j] = nums2[i];
                //     break;
                // }
                
                if(nums1[j] > nums2[i])
                {
                    for(int k = nums1.Length - 1; k > j - 1 && k != 0; --k)
                    {
                        nums1[k] = nums1[k - 1];
                    }
                    nums1[j] = nums2[i];
                    break;
                }
            }
        }

        foreach(var x in nums1)
        {
            Console.WriteLine(x);
        }
    }
}