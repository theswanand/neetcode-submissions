class Solution:
    def threeSum(self, nums: List[int]) -> List[List[int]]:
        res = []
        nums.sort()
        for i, a in enumerate(nums):
            # As List is in asc order, a greater than 0 indicates sum will never be 0
            if a > 0:
                break
            # Skip duplicates
            if i > 0 and nums[i - 1] == a: 
                continue
            l = i + 1
            r = len(nums) - 1
            while l < r:
                total = a + nums[l] + nums[r]
                if total > 0:
                    r = r - 1
                elif total < 0:
                    l = l + 1
                else:
                    res.append([a, nums[l], nums[r]])
                    # As match is found, Move both pointers inwards
                    l += 1
                    r -= 1
                    # Skip duplicates at the left pointer
                    while l < r and nums[l] == nums[l - 1]:
                        l += 1
        return res
