using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmStudy
{
    class GraphZL
    {
        public Vertex[] vertexs;

        public GraphZL(Vertex[] ver)
        {
            vertexs = ver;
        }


        public static GraphZL GetGraphZLInstance()
        {
            Vertex a = new Vertex("a");
            Vertex b = new Vertex("b");
            Vertex c = new Vertex("c");
            Vertex d = new Vertex("d");
            Vertex e = new Vertex("e");
            Vertex f = new Vertex("f");
            Vertex g = new Vertex("g");
            Vertex h = new Vertex("h");
            Vertex i = new Vertex("i");
            Vertex j = new Vertex("j");
            a.adjacentVertexs = new Vertex[] { c, d, e };
            b.adjacentVertexs = new Vertex[] { e, f };
            c.adjacentVertexs = new Vertex[] { a, d, f };
            d.adjacentVertexs = new[] { a, c };
            e.adjacentVertexs = new[] { a, b, f };
            f.adjacentVertexs = new[] { b, c, e };
            g.adjacentVertexs = new[] { h, j };
            h.adjacentVertexs = new[] { g, i };
            i.adjacentVertexs = new[] { h, j };
            j.adjacentVertexs = new[] { g, i };
            GraphZL graph = new GraphZL(new Vertex[] { a, b, c, d, e, f, g, h, i, j });
            return graph;
        }
    }

    class Vertex
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public bool Mark { get; set; }
        public Vertex[] adjacentVertexs;
        public int into;
        public int exit;
        public Vertex()
        { }
        public Vertex(string name)
        {
            Name = name;
        }
    }

}
