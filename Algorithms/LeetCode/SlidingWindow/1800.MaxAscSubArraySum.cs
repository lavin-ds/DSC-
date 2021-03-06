/*
1800. Maximum Ascending Subarray Sum
https://leetcode.com/problems/maximum-ascending-subarray-sum/
Easy

Given an array of positive integers nums, return the maximum possible sum of an ascending subarray in nums.

A subarray is defined as a contiguous sequence of numbers in an array.

A subarray [numsl, numsl+1, ..., numsr-1, numsr] is ascending if for all i where l <= i < r, numsi < numsi+1. Note that a subarray of size 1 is ascending.

Example 1:

Input: nums = [10,20,30,5,10,50]
Output: 65
Explanation: [5,10,50] is the ascending subarray with the maximum sum of 65.

Example 2:

Input: nums = [10,20,30,40,50]
Output: 150
Explanation: [10,20,30,40,50] is the ascending subarray with the maximum sum of 150.

Example 3:

Input: nums = [12,17,15,13,10,11,12]
Output: 33
Explanation: [10,11,12] is the ascending subarray with the maximum sum of 33.

Example 4:

Input: nums = [100,10,1]
Output: 100

Constraints:

    1 <= nums.length <= 100
    1 <= nums[i] <= 100
*/

using System;
using Xunit;

namespace Algorithms.LeetCode.SlidingWindow
{
    public class MaxAscSubArraySum
    {
        public int MaxAscendingSum(int[] nums) 
        {
            int max = 0;
            int runningTotal = 0;
            int prev = -1;
            for (int i = 0; i< nums.Length;i++)
            {
                if(nums[i]<=prev)
                {
                    max = Math.Max(max,runningTotal);
                    runningTotal = 0;
                }
                runningTotal = runningTotal+nums[i];
                prev = nums[i];
            }
            
            return Math.Max(max,runningTotal);
        }

        [Fact]
        public void TestWrap()
        {
            var arr1 = new int[]{10,20,30,5,10,50};
            var result =  MaxAscendingSum(arr1);
            Assert.Equal(65,result);

            var arr2 = new int[]{10,20,30,40,50};
            result =  MaxAscendingSum(arr2);
            Assert.Equal(150,result);

            var arr3 = new int[]{12,17,15,13,10,11,12};
            result =  MaxAscendingSum(arr3);
            Assert.Equal(33,result);

            var arr4 = new int[]{100,10,1};
            result =  MaxAscendingSum(arr4);
            Assert.Equal(100,result);

            var arr5 = new int[]{3,6,10,1,8,9,9,8,9};
            result =  MaxAscendingSum(arr5);
            Assert.Equal(19,result);
        } 
    }
}

