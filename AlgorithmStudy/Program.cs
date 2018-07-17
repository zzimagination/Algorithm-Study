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
            var listss= Chapter4.Array.LexicographicPermute(3);
            foreach (var item in listss)
            {
                foreach (var lists in item)
                {
                    Console.Write(lists + " ");

                }
                Console.WriteLine();

            }

            //List<List<int>> ls = Chapter4.BRGCpowerset.BRGC(3);


            //foreach (var item in ls)
            //{
            //    foreach (var value in item)
            //    {
            //        Console.Write(value);
            //    }
            //    Console.WriteLine();
            //}
            //int[] nums = { 1, 10, 12, 15, 65, 87, 89, 90, 100 };

            //Console.WriteLine( Chapter4.BinarySearchUtility.BinarySearch(nums,89));

            //int[] nums = { 8, 3, 2, 9, 7, 1, 5, 4 };
            //Chapter5.MergingSort.Sort(nums);
            //int[] numF= Chapter5.QuickSort.Sort(nums,0,7);
            //foreach (var item in numF)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadLine();
        }

       

    }
}
