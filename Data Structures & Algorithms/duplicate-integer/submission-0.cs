public class Solution {
    public bool hasDuplicate(int[] nums) {
        var hasValues = new HashSet<int>();
        foreach(var item in nums){
            if(hasValues.Contains(item))
                return true;
            hasValues.Add(item);
        }
        return false;
    }
}