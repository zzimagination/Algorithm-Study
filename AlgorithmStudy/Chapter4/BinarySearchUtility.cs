using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmStudy.Chapter4
{
    /// <summary>
    /// 折半查找法
    /// 输入一个升序数组和一个查找键
    /// 输出一个数组下标，该元素等于K，如果没有符合条件的值，返回-1
    /// </summary>
    class BinarySearchUtility
    {
        public static int BinarySearch(int[] numbers,int K)
        {
            int l = 0, r = numbers.Length - 1;
            while(l<=r)
            {
                int m = ((l + r) / 2);
                if(numbers[m]==K)
                {
                    return m;
                }else if(K<numbers[m])
                {
                    r = m - 1;
                }else
                {
                    l = m + 1;
                }
            }
            return -1;
                
        }
    }
}
