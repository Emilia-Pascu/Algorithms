using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public static class Sort
    {
        public static int[] BubbleSort(this int[] nums)
        {
            var swapped = false;
            do
            {
                swapped = false;
                for (var i = 0; i < nums.Length - 1; i++)
                {                    
                    if (nums[i] > nums[i + 1])
                    {
                        var temp = nums[i];
                        nums[i] = nums[i + 1];
                        nums[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
            return nums;
        }

        public static int[] InsertionSort(this int[] nums)
        {
            for(var i = 1; i < nums.Length; i++ )
            {
                for (var j = 0; j < i; j++)
                {
                    if(nums[i] < nums[j])
                    {
                        var temp = nums[i];
                        for (var s = i; s > j; s-- )
                        {
                            nums[s] = nums[s-1];
                        }
                        nums[j] = temp;                        
                    }
                }
            }
            return nums;
        }

    }
}
