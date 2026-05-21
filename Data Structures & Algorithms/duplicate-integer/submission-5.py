class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        nums.sort()
        if not nums:
            return False
        last = nums[0]
        for num in nums[1:]:
            if num == last:
                return True
            last = num
        return False