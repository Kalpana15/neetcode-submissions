public class Solution {
    public bool IsValid(string s) {
        Dictionary<char,char> openParanthesis = new();
        openParanthesis.Add('(', ')');
        openParanthesis.Add('{','}');
        openParanthesis.Add('[',']');
        Stack<char> stack = new();
        foreach (char c in s){
            if(openParanthesis.ContainsKey(c)){
                stack.Push(c);
            }
            else{
                if (stack.Count==0){
                    return false;
                }
                char top = stack.Pop();
                if(openParanthesis[top]!=c){
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }
}
