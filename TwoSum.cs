public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var numbers = new List<int>(nums);
        
        for(int i = 0; i < numbers.Count(); i++) {
            var complement = target - nums[i];
            
            var index = numbers.FindIndex(f => f == complement);
            if(index >= 0 && index != i) {
               return new int[] { i, index };
            }
        }
        
        var indices = new List<int>();
        return indices.ToArray();
    }
}
