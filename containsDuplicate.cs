public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Array.Sort(nums);
            
        bool containsDuplicate = false;
                    
        for (int i = 0; i<nums.Count(); i++) {
            if (i == nums.Count()) {
                continue;
            }
            
            if (nums[i] == nums[i+1]){
                containsDuplicate = true;
                break;
            }
        }
        
        return containsDuplicate;
    }
}
