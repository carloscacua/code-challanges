"""
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.
"""


def twoSum(self, nums, target):
    """
    :type nums: List[int]
    :type target: int
    :rtype: List[int]
    """
    complement = {}
    for i, elem in enumerate(nums):
        c = target - elem;
        if c in complement:
            return [complement[c], i]
        else:
            complement[elem] = i
