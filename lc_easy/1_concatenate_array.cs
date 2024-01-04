// First question solved - This is my hello world :D

// Link: https://leetcode.com/problems/concatenation-of-array/submissions/

public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n = nums.Length;
        int[] res = new int[2*n];
        
        for (int i = 0; i < 2*n; i++){
            if (i < n){
                res[i] = nums[i];
            }
            else{
                res[i] = nums[i-n];
            }
        }
        
        return res;
    }
}
