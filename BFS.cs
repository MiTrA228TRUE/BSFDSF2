using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSFDSF2
{
    public class BFS
    {
        Graph graph;

        List<GraphVertexInfo> infos;

        public BFS(Graph graph)
        {
            this.graph = graph;
        }

        void InitInfo()
        {
            infos = new List<GraphVertexInfo>();
            foreach (var v in graph.Vertices)
            {
                infos.Add(new GraphVertexInfo(v));
            }
        }

        GraphVertexInfo GetVertexInfo(GraphVertex v)
        {
            foreach (var i in infos)
            {
                if (i.Vertex.Equals(v))
                {
                    return i;
                }
            }

            return null;
        }

        public string FindAllPaths(string startVertexName)
        {
            var startVertex = graph.FindVertex(startVertexName);
            if (startVertex == null)
            {
                throw new ArgumentException("Start vertex not found");
            }

            return FindAllPaths(startVertex);
        }

        public string FindAllPaths(GraphVertex startVertex)
        {
            InitInfo();
            var first = GetVertexInfo(startVertex);
            first.EdgesWeightSum = 0;

            var queue = new Queue<GraphVertexInfo>();
            queue.Enqueue(first);

            StringBuilder result = new StringBuilder();

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                if (current.IsUnvisited == true)
                {
                    current.IsUnvisited = false;
                    result.Append(current.Vertex + ", ");

                    foreach (var e in current.Vertex.Edges)
                    {
                        var nextInfo = GetVertexInfo(e.ConnectedVertex);
                        var sum = current.EdgesWeightSum + e.EdgeWeight;
                        if (sum < nextInfo.EdgesWeightSum)
                        {
                            nextInfo.EdgesWeightSum = sum;
                            nextInfo.PreviousVertex = current.Vertex;
                        }

                        if (nextInfo.IsUnvisited)
                        {
                            queue.Enqueue(nextInfo);
                        }
                    }
                }
            }
            return result.ToString();
        }
    }
}
