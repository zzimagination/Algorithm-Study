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
            //Chapter4.Array.LexicographicPermute(10);


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
            //int[] numF= Chapter5.QuickSort.Sort(nums,0,7);
            //foreach (var item in numF)
            //{
            //    Console.WriteLine(item);
            //}

            Thread tr1 = new Thread(ThreadStudy);
            tr1.Priority = ThreadPriority.Lowest;
            Thread tr2 = new Thread(ThreadStudy2);
            tr2.Priority = ThreadPriority.Highest;
            tr1.Start();
            tr2.Start();
            start = true;
            Sleep(TimeSpan.FromSeconds(4));
            start = false;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.ReadLine();
        }

        static int num1;
        static int num2;
        static bool start;
        static void ThreadStudy()
        {

            while(start)
            {
                num1++;
                
            }
        }

        static void ThreadStudy2()
        {
            while(start)
            {
                num2++; 
            }
        }

    }
}
