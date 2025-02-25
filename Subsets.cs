using System.Collections.Generic;

public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        int totalSubsets = (int)Math.Pow(2,nums.Length); 

        for (int listposition = 0; listposition < totalSubsets; listposition++){
            List<int> subset = new List<int>();
            for (int i = 0; i < nums.Length; i++) {
                if ((listposition & ((int)Math.Pow(2,i))) != 0) {
                    subset.Add(nums[i]);
                }
            }
            result.Add(subset);
        }
        return result;
    }
}
