public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        if (strs.Length == 0){
            return new List<List<string>>();
        }

        Dictionary<string, List<string>> anagrams = new();
        foreach (string word in strs){
            int[] count = new int[26];
            foreach (char c in word){
                count[c-'a']++;
            }

            StringBuilder sb = new StringBuilder();
            for (int i=0; i< 26; i++){
                sb.Append("#");
                sb.Append(count[i]);
            }
            string key = sb.ToString();

            if(!anagrams.ContainsKey(key)){
                anagrams[key] = new List<string>();
            }

            anagrams[key].Add(word);       
        }

        return new List<List<string>>(anagrams.Values);
        
    }
}
