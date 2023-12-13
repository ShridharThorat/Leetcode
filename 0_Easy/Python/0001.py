# 0001 - Two Sum.py

import typing
from typing import Union
class Solution:
    def twoSum(self, nums: list[int], target: int) -> list[int]:
        complement_i = {}
        for i in range(0,len(nums)):
            if complement_i.get(nums[i],None) != None:
                return [i, complement_i[nums[i]]]
            else:
                complement_i[target-nums[i]] = i
        

sol = Solution()
print(sol.twoSum([1,1,1,1,1,4,1,1,1,1,1,7,1,1,1,1,1],11))