using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmStudy
{
    class Depth_first_Search
    {
        static int into;
        static int exit;
        public static void DFS(GraphZL graph)
        {

            foreach (var ver in graph.vertexs)
            {
                if(ver.Mark==false)
                {
                    dfs(ver);
                }
            }
        }

        static void dfs(Vertex ver)
        {
            into++;
            ver.into = into;
            ver.Mark = true;
            foreach (var v in ver.adjacentVertexs)
            {
                if(v.Mark==false)
                {
                    dfs(v);
                
                }
            }
            exit++;
            ver.exit = exit;
        }
    }
}
