using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmStudy.Chapter4
{
    class Array
    {

        public static void LexicographicPermute(int n)
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
                int max = 0;
                for (int i = 0; i < listFirst.Count-1; i++)
                {
                    if (listFirst[i] < listFirst[i + 1])
                        max = i;
                    else
                        continue;
                }
                int j=0;
                for (int i = 0; i < listFirst.Count; i++)
                {
                    if(listFirst[max]<listFirst[i])
                    {
                        j = i;
                    }
                }
                int mid = listFirst[max];
                listFirst[max] = listFirst[j];
                listFirst[j] = mid;
                List<int> listNew = new List<int>();

                for (int i = 0; i <= max; i++)
                {
                    listNew.Add(listFirst[i]);
                }

                for (int i =listFirst.Count-1; i >max; i--)
                {
                    listNew.Add(listFirst[i]);
                }
                lists.Add(listNew);
                listFirst = listNew;
                for (int i = 0; i < listFirst.Count-1; i++)
                {
                    if(listFirst[i]<listFirst[i+1])
                    {
                        isFor = true;
                        break;
                    }else
                    {
                        isFor = false;
                    }
                }

            }

            Console.WriteLine(lists.Count);
        }
    }
}
