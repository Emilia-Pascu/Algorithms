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
                var j = i - 1;
                var currentValue = nums[i];
                while (j >= 0 && nums[j] > currentValue)
                {
                    nums[j + 1] = nums[j];
                    j--;
                }
                nums[j + 1] = currentValue;
            }
            return nums;
        }

    }
}
