using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Threading.Thread;
using System.Threading;

namespace AlgorithmStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int[] nums = { 8, 3, 2, 9, 7, 1, 5, 4 ,4,6235,999,6,67,78,3312,789,658,2,98675};
            nums= Chapter5.MergingSort.Sort(nums);
           
            foreach (var item in nums)
            {
                Console.Write(item+" ");
            }

            Console.ReadLine();
        }

       

    }
}
