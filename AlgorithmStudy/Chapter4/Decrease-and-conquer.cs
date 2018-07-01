using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmStudy.Chapter4
{
    class Decrease_and_conquer
    {
        public static void InSort()
        {

            Vertex vertex = new Vertex("c1");
            Vertex vertex1 = new Vertex("c2");
            Vertex vertex2 = new Vertex("c3");
            Vertex vertex3 = new Vertex("c4");
            Vertex vertex4 = new Vertex("c5");

            vertex.adjacentVertexs = new Vertex[] { vertex2 };
            vertex1.adjacentVertexs = new Vertex[] { vertex2 };
            vertex2.adjacentVertexs = new Vertex[] { vertex3,vertex4 };
            vertex3.adjacentVertexs = new Vertex[] { vertex4 };
            vertex4.adjacentVertexs = new Vertex[] {  };

            Vertex[] vertices = new []{ vertex, vertex1, vertex2, vertex3, vertex4 };

            GraphZL graphZL = new GraphZL(vertices);
            Depth_first_Search.DFS(graphZL);
            int[] nums = new int[graphZL.vertexs.Length];
            for (int i = 0; i < graphZL.vertexs.Length; i++)
            {
                nums[i] = graphZL.vertexs[i].exit;
            }

            nums = InsertionSort.Excute(nums);
            foreach (var item in nums)
            {
                var vertexss = graphZL.vertexs.Where(a => a.exit == item);
                Console.WriteLine(vertexss.First().Name);
            }
        }
    }
}
