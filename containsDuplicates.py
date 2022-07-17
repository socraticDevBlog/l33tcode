def count(list):
    r = 0
    for x in list:
        r = r + 1;

    return r;

class Solution:
    
    def containsDuplicate(self, nums: List[int]) -> bool:
        nums_no_duplicates = list(dict.fromkeys(nums))
        
        og_count = count(nums)
        filtered_count = count(nums_no_duplicates)
        
        return og_count > filtered_count
      
      
# Runtime: 521 ms, faster than 77.44% of Python3 online submissions for Contains Duplicate.
# Memory Usage: 25.9 MB, less than 72.31% of Python3 online submissions for Contains Duplicate.
