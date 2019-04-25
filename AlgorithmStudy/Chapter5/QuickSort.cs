using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmStudy.Chapter5
{
    class QuickSort
    {
        /// <summary>
        /// 快速排序法
        /// 输入数组a和相对子数组左下标l，右下标r
        /// 输出非降序数组
        /// </summary>
        /// <param name="arrays"></param>
        /// <param name="l"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static int[] Sort(int[] arrays)
        {

            _Sort(arrays, 0, arrays.Length-1);
            return arrays;
        }


        static void _Sort(int[] arrays, int l, int r)
        {
            if (l < r)
            {
                int s = HoarePartition(arrays, l, r);
                _Sort(arrays, l, s-1);
                _Sort(arrays, s, r);
            }
        }

        /// <summary>
        /// 以第一个元素为中轴对子数组进行划分
        /// 输入数组a[0,n-1]
        /// 输出a的一个划分，分裂点为返回值
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        static int HoarePartition(int[] numbers, int l, int r)
        {
            int p = numbers[l];
            int i = l + 1;
            int j = r;
            while (i < j)
            {
                while (i < r)
                {

                    if (numbers[i] > p)
                        break;
                    i ++;
                }
                while (j > l + 1)
                {
                    if (numbers[j] <= p)
                        break;
                    j --;
                }

                if (i < j)
                {
                    numbers[i] = numbers[i] + numbers[j];
                    numbers[j] = numbers[i] - numbers[j];
                    numbers[i] = numbers[i] - numbers[j];
                }
            }
            if (numbers[j]<numbers[l])
            {
                numbers[l] = numbers[l] + numbers[j];
                numbers[j] = numbers[l] - numbers[j];
                numbers[l] = numbers[l] - numbers[j];
            }
            return j;
        }

    }
}
