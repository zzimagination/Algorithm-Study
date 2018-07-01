using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmStudy.Chapter3
{
    class GraphSearchOperate
    {
        public static void FSExcute()
        {

            GraphZL graph = GraphZL.GetGraphZLInstance();
            //Depth_first_Search.DFS(graph);
            //foreach (var item in graph.vertexs)
            //{
            //    Console.WriteLine(item.Name + " " + item.into + " " + item.exit);
            //}

            Breadth_first_Search.BFS(graph);

            foreach (var item in graph.vertexs)
            {
                Console.WriteLine(item.Name + " " + item.into + " " + item.exit);
            }
        }


    }
}
