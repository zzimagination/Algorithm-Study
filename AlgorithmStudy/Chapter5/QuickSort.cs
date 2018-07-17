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
        public static int[] Sort(int[] arrays,int l, int r)
        {
            if (l<r)
            {
                int s = HoarePartition(arrays,l,r);
                
                Sort(arrays,l,s-1);
                Sort(arrays,s+1,r);

             
            }
            return arrays;
        }

        /// <summary>
        /// 以第一个元素为中轴对子数组进行划分
        /// 输入数组a[0,n-1]
        /// 输出a的一个划分，分裂点为返回值
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int HoarePartition(int[] numbers,int l, int r)
        {
            int p = numbers[l];
            int i = l+1;
            int j = r;
            while (i < j)
            {
                while (numbers[i] < p)
                {
                    i += 1;
                    if (i > r)
                        break;
                }
                while (numbers[j] > p)
                {
                    j -= 1;
                }
                numbers[i] = numbers[i] + numbers[j];
                numbers[j] = numbers[i] - numbers[j];
                numbers[i] = numbers[i] - numbers[j];

            }
            numbers[i] = numbers[i] + numbers[j];
            numbers[j] = numbers[i] - numbers[j];
            numbers[i] = numbers[i] - numbers[j];

            numbers[l] = numbers[l] + numbers[j];
            numbers[j] = numbers[l] - numbers[j];
            numbers[l] = numbers[l] - numbers[j];

            return j;
        }

    }
}
