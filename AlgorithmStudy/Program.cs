using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgorithmStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chapter4.Array.LexicographicPermute(10);


            List<List<int>> ls = Chapter4.BRGCpowerset.BRGC(3);


            foreach (var item in ls)
            {
                foreach (var value in item)
                {
                    Console.Write(value);
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
