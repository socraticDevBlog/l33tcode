class Solution {
public:
    bool containsDuplicate(vector<int>& nums) {
        int ogNumsCount = 0;
        for (int x: nums) {
            ogNumsCount++;
        }
        
        sort(nums.begin(), nums.end());
        nums.erase(unique(nums.begin(), nums.end() ), nums.end());   
        
        int uniqueNumsCount = 0;
        for (int x: nums) {
            uniqueNumsCount++;
        }
        
        return ogNumsCount > uniqueNumsCount;
    }
};

// Runtime: 114 ms, faster than 79.25% of C++ online submissions for Contains Duplicate.
// Memory Usage: 46.5 MB, less than 97.54% of C++ online submissions for Contains Duplicate.
