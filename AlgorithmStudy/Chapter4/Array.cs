using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmStudy.Chapter4
{
    class Array
    {

        public static List<List<int>> LexicographicPermute(int n)
        {
            List<List<int>> lists = new List<List<int>>();
            List<int> listFirst = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                listFirst.Add(i);
            }
            lists.Add(listFirst);


            bool isFor = true;
            while(isFor)
            {
                List<int> listNew = new List<int>(lists[lists.Count-1]);
                int i = 0;
                for (int c = 0; c < listNew.Count-1; c++)
                {
                    if (listNew[c] < listNew[c + 1])
                        i = c;
                }
                int j=0;
                for (int c= 0; c< listNew.Count; c++)
                {
                    if(listNew[i]< listNew[c])
                    {
                        j = c;
                    }
                }
                int mid = listNew[i];
                listNew[i] = listNew[j];
                listNew[j] = mid;


                for (int c = 0; ; c++)
                {
                    int a = i + 1 + c;
                    int b = n-1 - c;
                    if (a >= b)
                        break;
                    int midNum = listNew[a];
                    listNew[a] = listNew[b];
                    listNew[b] = midNum;

                }
                
                lists.Add(listNew);
                //foreach (var listsss in listNew)
                //{
                //    Console.Write(listsss + " ");

                //}
                //Console.WriteLine();
                for (int c = 0; c < listNew.Count - 1; c++)
                {
                    if (listNew[c] < listNew[c + 1])
                    {
                        isFor = true;
                        break;
                    }
                    else
                    {
                        isFor = false;
                    }
                }
            }

          
            return lists;
        }
    }
}
