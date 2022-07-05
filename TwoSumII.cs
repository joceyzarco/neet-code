public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var indices = new List<int>(); 
        var firstIndex = 0;
        var secondIndex = numbers.Length - 1;
        
        
        for(int i = 0; i < numbers.Length; i++) {
            if(target < numbers[firstIndex] + numbers[secondIndex]) {
                secondIndex--;
            }
            else if(target > numbers[firstIndex] + numbers[secondIndex]) {
                firstIndex++;
            }
            else {
                indices.Add(firstIndex + 1);
                indices.Add(secondIndex + 1);
                
                break;
            }
        }
        
        return indices.ToArray();
    }
}
