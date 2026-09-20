public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> result = new ();
        Array.Sort(nums);

        for (int i=0; i< nums.Length; i++){
            if (i> 0 && nums[i]==nums[i-1])
                continue;

            int left = i+1;
            int right = nums.Length-1;
            while (left < right){
                int threeSum = nums[i]+nums[left]+nums[right];
                if (threeSum < 0){
                    left++;
                }
                else if (threeSum >0){
                    right--;
                }
                else{
                    List<int> currentList = [
                        nums[i],
                        nums[left],
                        nums[right]
                    ];
                    result.Add(currentList);
                    left++;

                    while (nums[left]==nums[left-1] && left<right)
                        left++;
                }
            }
        }
        return result;
    }
}
