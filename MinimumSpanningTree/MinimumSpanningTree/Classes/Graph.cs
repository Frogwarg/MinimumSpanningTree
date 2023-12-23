using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System;

namespace MinimumSpanningTree
{
    public class Graph
    {
        public int[,] mas;
        //public List<Node> myNodes,minimumST;
        public Graph() { }
        public void newGraph(List<Node> list) //создание таблицы смежности для графа
        {
            //this.myNodes = list;
            //minimumST = new List<Node>();
            mas = new int[list.Count+1, list.Count+1];
            for (int i = 1; i < mas.GetLength(0); i++)
            {
                mas[0, i] = list[i-1].order;
            }
            for (int i = 1; i < mas.GetLength(0); i++)
            {
                mas[i, 0] = list[i-1].order;
            }
            for (int i = 1; i < mas.GetLength(0); i++)
            {
                for (int j = 1; j < mas.GetLength(1); j++)
                {
                    if (list[i - 1].connected.Contains(list[j - 1]))
                    {
                        int index = list[i - 1].connected.IndexOf(list[j - 1]);
                        mas[i, j] = list[i - 1].lines[index].length;
                    } else
                    {
                        mas[i, j] = 0;
                    }
                }
            }
        }
        public void masOut(DataGridView table) //вывод таблицы смежности в DataGridView
        {
            table.Rows.Clear();
            table.Columns.Clear();
            int rows = mas.GetLength(0);
            int cols = mas.GetLength(1);
            for (int i = 0; i < cols-1; i++)
            {
                table.Columns.Add($"Column{i + 1}", $"{mas[0,i+1]}");
            }
            for (int i = 1; i < rows; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.HeaderCell.Value = mas[i, 0].ToString();

                for (int j = 1; j < cols; j++)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = mas[i, j] });
                }

                table.Rows.Add(row);
            }
        }
        public List<Node> primTree(List<Node> nodes, Label label, ref List<Connecter> connectors, out int oper) //алгоритм Прима
        {
            List<Node> result = new List<Node>();
            HashSet<Node> visited = new HashSet<Node>();
            int ans = 0;
            oper = 1;
            Node start = nodes[0];
            visited.Add(start); //добавляем первую произвольную вершины в список посещённых
            result.Add(new Node(start.center.X, start.center.Y, start.order, start.value)); //и в МОД
            oper += 8;
            while (visited.Count < nodes.Count)
            {
                Connecter min = null;
                Node next=null, current = null;
                foreach (Node node in visited) //идём по посещённым вершинам
                {
                    foreach (Connecter line in node.lines) 
                    {
                        if (visited.Contains(line.node2)) //если ребро посещённой вершины связано с вершиной, которая
                        {
                            oper++;                              //уже посещена, то идём к следующему ребру
                            continue;
                        }
                        oper++;
                        if (min == null || line.length < min.length) //находим минимальное ребро у посещённой вершины
                        {                                            //и сохраняем его
                            min = line;
                            next = line.node2;
                            current = node;                          //а также саму вершину
                            oper += 3;
                        }
                        oper+=4;
                    }
                    oper++;
                }
                if (next != null) 
                {
                    Node help = new Node(next.center.X, next.center.Y, next.order, next.value);
                    foreach (Node node in result)
                    {
                        if (node.order == current.order)             //вершину с минимальным непосещённым ребром
                        {
                            node.Connect(next,ref oper,min.length);           //мы соединяем с непосещённой вершиной
                            help.Connect(node,ref oper,min.length);
                            connectors.Add(new Connecter(node,help,min.length)); //сохраняем МОД
                            oper+=4;
                        }
                        oper+=2;
                    }
                    next.min = visited.First(n => n.lines.Contains(min)); //сохраняем у вершины данные о вершине, 
                    next.shortest = min;                                  //с которой она связаны минимальным ребром
                    visited.Add(next);                              //посетили вершину
                    result.Add(help);
                    ans += min.length;                              //посчитали итоговый вес МОД
                    oper += 10;
                }
                oper += 2;
            }
            label.Text = "Вес=" + ans.ToString();
            oper++;
            return result;
        }
        public List<Node> kraskTree(List<Node> nodes, Label label, ref List<Connecter> connectors, out int oper) //алгоритм Борувки
        {
            List<Connecter> edges = new List<Connecter>();
            List<Node> result = new List<Node>();
            DisjointSet disjointSet = new DisjointSet();
            int ans = 0;
            oper = 1;
            foreach (Node node in nodes)
            {
                foreach (Connecter connecter in node.lines)
                {
                    edges.Add(new Connecter(node, connecter.node2, connecter.length)); //получение всех рёбер
                    oper += 5;
                }
                oper++;
            }
            edges.Sort((a, b) => a.length.CompareTo(b.length)); //сортируем все рёбра по возрастанию
            if (edges.Count > 0)
            {
                oper += edges.Count * Convert.ToInt32(Math.Log10(edges.Count));
            }
            foreach (Node node in nodes)
            {
                disjointSet.MakeSet(node); //создаем новое множество, содержащее только один элемент
                oper+=2;
            }
            foreach (Connecter edge in edges)
            {
                Node root1 = disjointSet.Find(edge.node1, ref oper); //находим корневой элемент множества, содержащего начальный и конечный узел ребра
                Node root2 = disjointSet.Find(edge.node2, ref oper);

                if (root1 != root2)
                {
                    disjointSet.Union(root1, root2, ref oper); //объединяем оба множества
                    Node node1 = new Node(edge.node1.center.X, edge.node1.center.Y, edge.node1.order, edge.node1.value);
                    Node node2 = new Node(edge.node2.center.X, edge.node2.center.Y, edge.node2.order, edge.node2.value);
                    node1.Connect(node2,ref oper, edge.length); //соединяем узлы
                    node2.Connect(node1,ref oper, edge.length);
                    result.Add(node1); //добавляем узлы в МОД
                    result.Add(node2);
                    ans += edge.length; //считаем итоговый вес МОД
                    connectors.Add(edge);
                    oper += 12;
                }
                oper += 4;
            }
            label.Text = "Вес=" + ans.ToString();
            oper++;
            return result;
        }
        public List<Node> boruvkaTree(List<Node> nodes, Label label, ref List<Connecter> connectors, out int oper) //алгоритм Борувки
         {
            List<Node> result = new List<Node>();
            List<List<Node>> forest = new List<List<Node>>();
            List<Node> helper = new List<Node>(nodes);
            oper = 0;
            List<Connecter> edges = getConnecters(helper, ref oper);
            int ans = 0;
            oper++;
            int iter = 0;
            foreach (Node node in nodes) //создаём лес деревьев, в каждом из которых по одному элементу
            {
                List<Node> tree = new List<Node>();
                tree.Add(node);
                forest.Add(tree);
                oper += 3;
            }
            while (forest.Count > 1)
            {
                List<Connecter> cheapestConnecters = getCheapestConnecters(nodes, edges, ref oper); //получаем набор наименьших рёбер
                foreach (Connecter edge in cheapestConnecters)
                {
                    List<Node> node1Tree = null;
                    List<Node> node2Tree = null;

                    foreach (List<Node> tree in forest) //определяем компоненты
                    {
                        if (tree.Contains(edge.node1)) //если в дереве содержится начальный узел ребра, то сохраняем это дерево
                        {
                            node1Tree = tree;
                            oper++;
                        }

                        if (tree.Contains(edge.node2)) //если в дереве содержится конечный узел ребра, то сохраняем это дерево
                        {
                            node2Tree = tree;
                            oper++;
                        }
                        oper += 3;
                    }
                    if ((node1Tree !=null && node2Tree != null) && node1Tree != node2Tree)
                    {
                        Node node1 = new Node(edge.node1.center.X, edge.node1.center.Y, edge.node1.order, edge.node1.value);
                        Node node2 = new Node(edge.node2.center.X, edge.node2.center.Y, edge.node2.order, edge.node2.value);
                        node1.Connect(node2, ref oper, edge.length); //соединяем узлы
                        node2.Connect(node1, ref oper, edge.length);
                        result.Add(node1); //добавляем узлы в МОД
                        result.Add(node2);
                        ans += edge.length; //считаем итоговый вес МОД
                        connectors.Add(edge); //сохраняем рёбра МОД
                        List<Node> mergedTree = null;
                        mergedTree = node1Tree.Concat(node2Tree).ToList(); //соединяем компоненты
                        forest.Remove(node1Tree); //удаляем из леса отдельные деревья
                        forest.Remove(node2Tree);
                        forest.Add(mergedTree); //заносим в лес компоненту
                        oper += 16;
                    }
                    else if (forest.Count == 2) //если в лесу остались две компоненты
                    {
                        List<Connecter> cons1 = new List<Connecter>();
                        List<Connecter> cons2 = new List<Connecter>();
                        foreach (Node node in forest[0])
                        {
                            foreach (Connecter line in node.lines)
                            {
                                cons1.Add(line);                //получаем наборы рёбер в одной компоненте
                                oper += 2;
                            }
                            oper++;
                        }
                        foreach (Node node in forest[1])
                        {
                            foreach (Connecter line in node.lines)
                            {
                                cons2.Add(line);                //получаем наборы рёбер во второй компоненте
                                oper += 2;
                            }
                            oper++;
                        }
                        Connecter goal = new Connecter();
                        if (cons1.Count > cons2.Count) //в зависимости от количества узлов в каждой компоненте
                        {
                            goal = method(cons1, connectors, forest[0], ref oper);
                            oper++;
                        }
                        else
                        {
                            goal = method(cons2, connectors, forest[1], ref oper);
                            oper++;
                        }                                       //находим минимальное ребро, которое соединяет обе компоненты, не создавая цикла
                        try
                        {
                            Node noda1 = result.Find(x => x.value == goal.node1.value);
                            Node noda2 = result.Find(x => x.value == goal.node2.value);
                            noda1.Connect(noda2, ref oper, goal.length); //соединяем узлы
                            noda2.Connect(noda1, ref oper, goal.length);
                            connectors.Add(goal); //сохраняем ребро в МОД
                            ans += goal.length; //считаем итоговый вес дерева
                            forest.Remove(node1Tree); //удаляем ненужную компоненту
                            oper += 6;
                        }
                        catch (NullReferenceException ex)
                        {
                            MessageBox.Show("Ошибка!"+ex.Message);
                        }
                        catch
                        {
                            MessageBox.Show("Неизвестная ошибка!");
                        }

                    }
                    oper += 2;
                }
                oper += 2;
                iter++;
                if (iter >= nodes.Count + 1)
                {
                    break;
                }
            }
            label.Text = "Вес=" + ans.ToString();
            oper++;
            return result;
        }
        public Connecter method(List<Connecter> cons, List<Connecter> connectors, List<Node> forest, ref int oper) //получение минимального не включенного ребра
        {
            Connecter goal = new Connecter();
            cons.Sort((a, b) => a.length.CompareTo(b.length)); //сортируем рёбра в компоненте
            oper += cons.Count * Convert.ToInt32(Math.Log10(cons.Count));
            for (int i = 0; i < cons.Count; i++)
            {
                List<Connecter> line = connectors.FindAll(x => x.length == cons[i].length); //находим в конечном МОД рёбра с таким же весом
                oper += connectors.Count;
                if (line.Count == 0 && !forest.Contains(cons[i].node2)) //если таких же рёбер нет и ребро не соединено с вершиной, которая уже в дереве
                {
                    goal = cons[i]; //то сохраняем нужное нам ребро
                    oper += 4;
                    break;
                }
                oper += 3;
            }
            return goal;
        }
        public List<Connecter> getConnecters(List<Node> nodes, ref int oper) //получение списка всех рёбер в графе
        {
            List<Connecter> edges = new List<Connecter>();
            foreach (Node node in nodes)
            {
                foreach (Node neighbor in node.connected)
                {
                    edges.Add(new Connecter(node, neighbor, node.lines[node.connected.IndexOf(neighbor)].length));
                    oper += 5;
                }
                oper++;
            }
            return edges;
        }
        public List<Connecter> getCheapestConnecters(List<Node> nodes, List<Connecter> edges, ref int oper) //получение списка наименьших рёбер
        {
            List<Connecter> cheapestConnecters = new List<Connecter>();
            foreach (Node node in nodes)
            {
                Connecter cheapestConnecter = null;
                foreach (Connecter edge in edges)
                {
                    if (edge.node1 == node || edge.node2 == node)
                    {
                        if (cheapestConnecter == null || edge.length < cheapestConnecter.length)
                        {
                            cheapestConnecter = edge;
                            oper++;
                        }
                        oper += 3;
                    }
                    oper += 4;
                }
                cheapestConnecters.Add(cheapestConnecter);
                oper += 2;
            }
            return cheapestConnecters;
        }
    }
}
