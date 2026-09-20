public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int left = 0;
        int right = 0;
        int length = 0;
        HashSet<char> hashset = new();

        while (right < s.Length){
            if (!hashset.Contains(s[right])){
                hashset.Add(s[right]);
                right++;
                length = Math.Max(length, right-left);
            }
            else{
                hashset.Remove(s[left]);
                left++;
            }
        }
        return length;
    }
}
