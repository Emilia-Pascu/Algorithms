using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public static class Permutation
    {
        public static int[] MoveZeroesToEnd(this int[] nums)
        {
            var nonZeroes = 0;
            for(var i = 0; i < nums.Length; i++)
            {
                if(nums[i] != 0)
                {
                    nums[nonZeroes++] = nums[i];
                }
            }
            
            for(var j = nonZeroes; j < nums.Length; j++ )
            {
                nums[j] = 0;
            }
            return nums;
        }
    }
}
