using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace MinimumSpanningTree
{
    [Serializable]
    public class Node
    {
        public Point center;
        public List<Node> connected = new List<Node>(); //список узлов, с которыми соединён узел
        public List<Connecter> lines = new List<Connecter>(); //рёбра, которые их связывают
        public Node min; //узел, который связан с текущим узлом ребром с минимальным весом
        public Connecter shortest; //минимальное ребро
        public string value; //значение
        public int order; //порядок
        public Node() { }
        public Node(float X, float Y, string value)
        {
            this.center.X = Convert.ToInt32(X);
            this.center.Y = Convert.ToInt32(Y);
            this.order = int.Parse(value);
            this.value = value;
        }
        public Node(float X, float Y, int order, string value)
        {
            this.center.X = Convert.ToInt32(X);
            this.center.Y = Convert.ToInt32(Y);
            this.order = order;
            this.value = value;
        }
        public void Connect(Node node, ref int oper, int length = 1) //соединяет один узел с другим
        {
            try
            {
                connected.Add(node); //добавляет узел
                lines.Add(new Connecter(this, node, length)); //добавляет ребро
                oper += 5;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Ошибка!");
            }
            //findShortest(connected, lines, ref oper); //находит узел, который связан с текущим узлом ребром с минимальным весом и само ребро
        }
        public void findShortest(List<Node> connected, List<Connecter> lines, ref int oper) //находит узел, который связан с текущим узлом ребром с минимальным весом и само ребро
        {
            int mini, index;
            if (lines.Count != 0)
            {
                mini = lines[0].length;
                index = 0;
                for (int i = 1; i < lines.Count(); i++)
                {
                    if (lines[i].length < mini)
                    {
                        mini = lines[i].length;
                        index = i;
                        oper += 2;
                    }
                    oper += 4;
                }
                this.min = connected[index];
                this.shortest = lines[index];
                oper += 5;
            }
        }
    }
}
