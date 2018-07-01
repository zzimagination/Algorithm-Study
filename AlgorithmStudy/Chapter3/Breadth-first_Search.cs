using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmStudy
{
    class Breadth_first_Search
    {
        static int into;

        public static void BFS(GraphZL graph)
        {
      
            foreach (var vert in graph.vertexs)
            {
                if(vert.Mark==false)
                {
                    bfs(vert);
                }
            }
        }

        static void bfs(Vertex vert)
        {
            into++;
            vert.into = into;
            vert.Mark = true;
            Queue<Vertex> vertQueue = new Queue<Vertex>();
            vertQueue.Enqueue(vert);
            while(vertQueue.Count>0)
            {
                Vertex first = vertQueue.Dequeue();
                foreach (var w in first.adjacentVertexs)
                {
                    if(w.Mark==false)
                    {
                        into++;
                        w.into = into;
                        w.Mark = true;
                        vertQueue.Enqueue(w);
                    }
                }
            }
        }
    }
}
