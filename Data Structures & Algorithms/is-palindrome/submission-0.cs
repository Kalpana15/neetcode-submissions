public class Solution {
    public bool IsPalindrome(string s) {
        int low = 0;
        int high = s.Length-1;
        while(low<high)
        {
            if(!char.IsLetterOrDigit(s[low]))
            {
                low++;
            }
            else if(!char.IsLetterOrDigit(s[high]))
            {
                high--;
            }
            else
            {
                if (char.ToUpper(s[low])!=char.ToUpper(s[high]))
                {
                    return false;
                }
                
                low++;
                high--;
            }       

        }
        return true;
    }
}
