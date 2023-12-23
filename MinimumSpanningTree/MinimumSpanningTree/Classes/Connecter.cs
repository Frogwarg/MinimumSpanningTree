using System;

namespace MinimumSpanningTree
{
    [Serializable]
    public class Connecter
    {
        public Node node1, node2;
        public int length;
        public Connecter() { }
        public Connecter(Node node1, Node node2, int length = 1)
        {
            this.node1 = node1;
            this.node2 = node2;
            this.length = length;
        }
    }
}
