// LIS problem

// 1D DP
// Link: https://leetcode.com/problems/longest-increasing-subsequence/


public class Solution {
    public int LengthOfLIS(int[] nums) {
        int n = nums.Length;
        int[] dp = Enumerable.Repeat(1, n).ToArray();
        
        int maxi = 1;
        for (int ind=0; ind < n; ind++){
            for (int prev = 0; prev < ind; prev ++){
                if (nums[ind] > nums[prev]){
                    dp[ind] = Math.Max(dp[ind], 1+dp[prev]);
                    maxi = Math.Max(maxi, dp[ind]);
                }
            }
        }
        return maxi;
    }
}
