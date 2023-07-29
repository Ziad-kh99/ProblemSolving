namespace LeetCode.Easy;


public class IntersectoinOfTwoArrays
{
    public static int[] Sulotion(int[] nums1, int[] nums2)
    {
        List<int> list = new List<int>();
        for(int i = 0; i < nums1.Length; ++i)
        {
            for(int j = 0; j < nums2.Length; ++j)
            {
                if(nums1[i] == nums2[j])
                {
                    if(!IsExist(list, nums1[i]))
                    {
                        list.Add(nums1[i]);
                        break;
                    }
                }
            }
        }

        int[] nums3 = list.ToArray();

        return nums3;
    }

    private static bool IsExist(List<int> list, int x)
    {
        for(int i = 0; i < list.Count; ++i)
        {
            if(x == list[i])
                return true;
        }

        return false;
    }
}