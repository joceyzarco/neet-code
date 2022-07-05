public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        return nums.GroupBy(n => n).Any(a => a.Count() > 1);;
    }
}
