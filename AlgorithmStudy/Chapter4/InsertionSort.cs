using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmStudy
{
    class InsertionSort
    {
        public static int[] Excute(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int a = nums[i];
                int j = i - 1;
                while(j>=0&&nums[j]>a)
                {
                    nums[j + 1] = nums[j];
                    j--;
                }
                nums[j + 1] = a;
            }
            return nums;
        }

    }
}
