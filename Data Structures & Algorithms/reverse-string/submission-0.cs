public class Solution {
    public void ReverseString(char[] s) {
        int left = 0;
        int right = s.Length-1;
        
        while (left < right){
            char k = s[left];
            s[left] = s[right];
            s[right] = k;

            left++;
            right--;
        }
    }
}