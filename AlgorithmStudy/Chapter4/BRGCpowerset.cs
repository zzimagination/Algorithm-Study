using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmStudy.Chapter4
{
    /// <summary>
    /// 二进制反射格雷码算法求一个集合的所有幂集的位串
    /// 输入一个正整数n
    /// 输出所有长度为n的格雷码位串列表
    /// </summary>
    public class BRGCpowerset
    {
        public static List<List<int>> BRGC(int n)
        {
            if (n < 1)
                return null;
            List<List<int>> powerSetsList = new List<List<int>>();
            if (n==1)
            {
                List<int> powerSet0 = new List<int>() { 0 };
                List<int> powerSet1 = new List<int>() { 1 };

                powerSetsList = new List<List<int>>() { powerSet0, powerSet1 };
               
            }else
            {
                List<List<int>> l1 = BRGC(n - 1);//递归
                List<List<int>> l2 = new List<List<int>>();
                for (int i = l1.Count-1; i >=0; i--)
                {
                    List<int> listMid = new List<int>(l1[i]);
                    l2.Add(listMid);
                }
                for (int i = 0; i < l1.Count; i++)
                {
                    l1[i].Insert(0, 0);
                    l2[i].Insert(0, 1);
                }



                l1.AddRange(l2);
                powerSetsList = l1;
             
               
            }
            //foreach (var item in powerSetsList)
            //{
            //    foreach (var ll in item)
            //    {
            //        Console.Write(ll);
            //    }
            //    Console.WriteLine();
            //}
            return powerSetsList;
        }
    }
}
