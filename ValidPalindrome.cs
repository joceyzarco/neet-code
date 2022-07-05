public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();
        s = String.Concat(Array.FindAll(s.ToCharArray(), Char.IsLetterOrDigit));
        
        if(String.IsNullOrEmpty(s) || s.Length == 1) {
            return true;
        }
        
        Char[] reversed = s.ToCharArray();
        Array.Reverse(reversed);
    

        return reversed.SequenceEqual(s);
    }
}
