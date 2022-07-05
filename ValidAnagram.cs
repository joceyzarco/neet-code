public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) {
            return false;
        }
        
        var sChars = s.ToCharArray();
        var tChars = t.ToCharArray();
        
        Array.Sort(sChars);
        Array.Sort(tChars);
        
        for(int i = 0; i < sChars.Length; i++) {
            if(tChars[i] != sChars[i]) {
                return false;
            }
        }
        
        return true;
    }
}
