using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSFDSF2
{
    public class GraphVertexInfo
    {
        public GraphVertex Vertex { get; set; }
        /// Не посещенная вершина
        public bool IsUnvisited { get; set; }
        /// Сумма весов ребер
        public int EdgesWeightSum { get; set; }

        /// Предыдущая вершина
        public GraphVertex PreviousVertex { get; set; }

        public GraphVertexInfo(GraphVertex vertex)
        {
            Vertex = vertex;
            IsUnvisited = true;
            EdgesWeightSum = int.MaxValue;
            PreviousVertex = null;
        }
    }
}
