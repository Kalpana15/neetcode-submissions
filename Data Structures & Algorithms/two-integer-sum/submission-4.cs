public class Solution {
    public int[] TwoSum(int[] nums, int target) { 
        Dictionary<int, int> hashmap = new Dictionary<int, int>();
        int[] result = new int[2];
        for (int i = 0; i<= nums.Length-1; i++){
            int diff = target - nums[i];
            if (hashmap.ContainsKey(diff)){
                result[0] = hashmap[diff];
                result[1] = i;
                return result;
            }
            else
            {
                hashmap.Add(nums[i],i);
            }
        }
        return result;
    }
}
