using System.Collections.Generic;

namespace MinimumSpanningTree
{
    public class DisjointSet
    {
        private Dictionary<Node, Node> parent = new Dictionary<Node, Node>();
        public void MakeSet(Node node) //создает новое множество, содержащее только один элемент
        {
            parent[node] = node;
        }
        public Node Find(Node node, ref int oper) //находим корневой элемент множества, содержащего узел 
        {
            if (parent[node] == node)
            {
                oper++;
                return node;
            }
            parent[node] = Find(parent[node], ref oper);
            oper+=3;
            return parent[node];
        }
        public void Union(Node node1, Node node2, ref int oper) //объединяет множества
        {
            parent[Find(node1, ref oper)] = Find(node2, ref oper);
        }
    }
}
