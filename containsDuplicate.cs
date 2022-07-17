public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var list = new List<int>();
        list.AddRange(nums);
        var distinctList = list.Distinct().ToList();
        return list.Count() != distinctList.Count(); 
    }
}

// Runtime: 263 ms, faster than 57.21% of C# online submissions for Contains Duplicate.
// Memory Usage: 47.4 MB, less than 48.39% of C# online submissions for Contains Duplicate.
(2022-07-17)
