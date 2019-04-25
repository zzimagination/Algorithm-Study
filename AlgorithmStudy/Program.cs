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


            int[] nums = new int[10];
            Random random = new Random(23232);
            for (int i = 0; i < nums.Length; i++)
            {
               
                nums[i] = random.Next(0,20);
            }
            //nums= Chapter5.MergingSort.Sort(nums);

            foreach (var item in nums)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            nums = Chapter5.QuickSort.Sort(nums);



            foreach (var item in nums)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }

       

    }
}
