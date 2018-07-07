using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmStudy.Chapter5
{

    class MergingSort
    {
        /// <summary>
        /// 合并排序
        /// 输入一个可排序数组
        /// 输出非降序排列的数组
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] Sort(int[] nums)
        {
            int count = nums.Length;
            if (count > 1)
            {
                int[] numA = new int[count / 2];
                int[] numB = new int[count-count / 2];
                int[] numC = new int[count];
                for (int i = 0; i < count; i++)
                {
                    if (i < count / 2)
                    {
                        numA[i] = nums[i];
                    }
                    else
                    {
                        numB[i - count / 2] = nums[i];
                    }
                }
                numA= Sort(numA);
                numB= Sort(numB);
                Merage(numA, numB, numC);
                return numC;
            }else
            {
                return nums;
            }
        }


        static int[] Merage(int[] A, int[] B, int[] C)
        {
            int p = A.Length;
            int q = B.Length;
            int i = 0, j = 0, k = 0;
            while (i < p && j < q)
            {
                if (A[i] <= B[j])
                {
                    C[k] = A[i];
                    i++;
                }
                else
                {
                    C[k] = B[j];
                    j++;
                }
                k++;
            }
            if (i == p)
            {
                for (int numI = j; numI < q; numI++)
                {
                    C[k] = B[j];
                    k++;
                }
            }
            else
            {
                for (int numI = i; numI < p; numI++)
                {
                    C[k] = A[i];
                    k++;
                }
            }

            return C;
        }

    }
}
