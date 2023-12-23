using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace MinimumSpanningTree
{
    public partial class Form1 : Form
    {
        private Point startPoint, currentPoint;
        public float circleSize = 50;
        public int clickCount = 0;
        public int kolvo = 0;
        private bool mooved = false;
        private bool startPicked= false;
        private bool addingState = false;
        private bool connectingState = false;
        private bool deletingState = false;
        private bool isMSTon = false;
        private Node node, nodeHelp, nodeHelp2;
        private Graph graph = new Graph();
        private List<Node> myNodes = new List<Node>();
        private List<Node> minimumSpanningTree = new List<Node>();
        private List<Connecter> connectors = new List<Connecter>();
        Bitmap map = new Bitmap(100, 100);

        Graphics graphics;
        Pen pen = new Pen(Color.Black, 3f);
        private void SetSize()
        {
            map = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            graphics = Graphics.FromImage(map);
            graphics.Clear(pictureBox1.BackColor);
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
        }
        public Form1()
        {
            InitializeComponent();
            Titul t = new Titul();
            //t.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SetSize();
            helperLable.Text = "Состояние: Ожидание";
            startPoint.X = -1;
            startPoint.Y = -1;
            nodePickTxt.Text = "";
            label1.Text = "Количество операций:";
            kolvo = 0;
            comboBox1.SelectedItem = comboBox1.Items[0];
            tableGraph.Columns.Clear();
            tableGraph.Rows.Clear();
            tableMod.Rows.Clear();
            tableMod.Columns.Add("From", "Из узла");
            tableMod.Columns.Add("To", "В узел");
            tableMod.Columns.Add("Length", "Вес");
            kolvo = myNodes.Count();
            FileStream fs = new FileStream("../../../../journal.txt", FileMode.Create);
        }
        private void addNodeBtn_Click(object sender, EventArgs e)
        {
            addingState = true;
            connectingState = false;
            deletingState = false;
            helperLable.Text = "Состояние: Добавление вершины";
        }
        private void connectBtn_Click(object sender, EventArgs e)
        {
            connectingState = true;
            addingState = false;
            deletingState = false;
            helperLable.Text = "Состояние: Связывание вершин";
        }
        private void delNodeBtn_Click(object sender, EventArgs e)
        {
            deletingState = true;
            addingState = false;
            connectingState = false;
            helperLable.Text = "Состояние: Удаление вершины";
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            mooved = true;
            currentPoint = e.Location;
            pictureBox1.Invalidate();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e) //рисуем только когда добавляем узел или соединяем узлы
        {
            if (addingState == true)
            {
                e.Graphics.DrawEllipse(pen, currentPoint.X - (circleSize / 2), currentPoint.Y - (circleSize / 2), circleSize, circleSize);
            }
            if (connectingState == true && startPicked==true)
            {
                e.Graphics.DrawLine(pen,startPoint.X,startPoint.Y,currentPoint.X,currentPoint.Y);
            }
        }
        private void очиститьToolStripMenuItem_Click_1(object sender, EventArgs e) //очистка поля
        {
            mooved = false;
            ClearStates();
            startPicked = false;
            graphics.Clear(pictureBox1.BackColor);
            myNodes.Clear();
            connectors.Clear();
            nodePickTxt.Text = "";
            nodeLink2.Text = "";
            deleteTxt.Text = "";
            curNameTxt.Text = "";
            newNameTxt.Text = "";
            lengthNum.Value = 1;
            kolvo = 0;
            tableGraph.Columns.Clear();
            tableGraph.Rows.Clear();
            tableMod.Rows.Clear();
            tabControl2.SelectedIndex = 0;
            pictureBox1.Invalidate();
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e) //действия по нажатию мыши
        {
            currentPoint = e.Location; //сохраняем текущую позицию
            float radius = circleSize / 2; //определяем радиус окружности узла
            for (int i = 0; i < myNodes.Count; i++)
            {
                Point listPoint = myNodes[i].center;
                //считаем расстояние между точкой нажатия мыши и центром близжайшего узла
                double dist = Math.Sqrt(Math.Abs(Math.Pow((listPoint.X - currentPoint.X), 2) + Math.Pow((listPoint.Y - currentPoint.Y), 2))); 
                if (dist < circleSize / 2) //если нажатие мыши произошло в пределах узла...
                {
                    deleteTxt.Text = myNodes[i].value.ToString(); //заполняем поля ввода данными узла
                    curNameTxt.Text = myNodes[i].value.ToString();
                    if (e.Button == MouseButtons.Left)
                    {
                        nodePickTxt.Text = myNodes[i].value.ToString();
                    } else if (e.Button==MouseButtons.Right)
                    {
                        nodeLink2.Text = myNodes[i].value.ToString();
                    }
                    nodeHelp2 = myNodes[i]; //сохраняем данные об узле, на который нажали
                }
            }
            if (addingState) //если мы добавляем узел
            {
                AddNode(radius);
            }
            if (connectingState) //если мы соединяем узлы
            {
                clickCount++; //считаем нажатия
                if (clickCount == 1) //если нажали один раз, значит найденный узел будет начальным
                {
                    for (int i = 0; i < myNodes.Count; i++)
                    {
                        Point listPoint = myNodes[i].center;
                        //считаем расстояние между точкой нажатия мыши и центром близжайшего узла
                        double dist = Math.Sqrt(Math.Abs(Math.Pow((listPoint.X - currentPoint.X), 2) + Math.Pow((listPoint.Y - currentPoint.Y), 2)));
                        if (dist < circleSize/2) //если нажатие мыши произошло в пределах узла...
                        {
                            startPoint = listPoint; //сохранили начальный узел
                            nodeHelp = myNodes[i]; //сохраняем о нём данные
                            startPicked = true;
                        }
                    }
                }
                if (clickCount == 2) //если нажали второй раз, значит найденный узел будет конечным
                {
                    clickCount = 0; //перестаём считать нажатия
                    for (int i = 0; i < myNodes.Count; i++)
                    {
                        Point listPoint = myNodes[i].center;
                        double dist = Math.Sqrt(Math.Abs(Math.Pow((listPoint.X - currentPoint.X), 2) + Math.Pow((listPoint.Y - currentPoint.Y), 2)));
                        //считаем расстояние между точкой нажатия мыши и центром близжайшего узла
                        if (dist < circleSize / 2) //если нажатие мыши произошло в пределах узла...
                        {   //если конечный узел уже не соединён с начальным и наоборот
                            if (nodeHelp!=null && !myNodes[i].connected.Contains(nodeHelp) && !nodeHelp.connected.Contains(myNodes[i]))
                            {
                                Link(nodeHelp, myNodes[i],1); //соединяем узлы и даём новому ребру вес 1
                                BuildGraph(); //строим матрицу смежности получившегося графа
                            }
                        }
                        else
                        {
                            startPicked = false;
                            connectingState = false;
                            helperLable.Text = "Состояние: Ожидание";
                        }
                    }
                }
                Redraw(myNodes); //перерисовываем
            }
            if (deletingState) //если удаляем узел
            {
                deletingState = false; //перестаём удалять
                for (int i = 0; i < myNodes.Count; i++)
                {
                    Point listPoint = myNodes[i].center;
                    //считаем расстояние между точкой нажатия мыши и центром близжайшего узла
                    double dist = Math.Sqrt(Math.Abs(Math.Pow((listPoint.X - currentPoint.X), 2) + Math.Pow((listPoint.Y - currentPoint.Y), 2)));
                    if (dist < circleSize / 2) //если нажатие мыши произошло в пределах узла...
                    {
                        startPoint = listPoint;
                        Delete(myNodes[i]); //удаляем узел
                    }
                }
                BuildGraph();
                Redraw(myNodes);
            }
            pictureBox1.Image = map;
        }
        public void AddNode(float radius) //метод для добавления узла в граф
        {
            addingState = false; //перестаём добавлять
            bool hover;
            if (isMSTon == true) //проверяем, будет ли новый узел перекрывать МОД или исходный граф
            {
                hover = isHovering(currentPoint, minimumSpanningTree);
            }
            else
            {
                hover = isHovering(currentPoint, myNodes);
            }
            if (hover == false) //если не перекрывает
            {
                kolvo++;                                                            //считаем количество узлов
                node = new Node(currentPoint.X, currentPoint.Y, (kolvo).ToString()); //создаём новый узел
                myNodes.Add(node);                                                  //добавляем узел в граф
                graphics.DrawEllipse(pen, currentPoint.X - radius, currentPoint.Y - radius, circleSize, circleSize); //рисуем узел, а в нём его значение
                SolidBrush br = new SolidBrush(pen.Color);
                graphics.DrawString(kolvo.ToString(), new Font("Times New Roman", 12), br, currentPoint.X - 5 - pen.Width / 2, currentPoint.Y - 8 - pen.Width / 2);
                helperLable.Text = "Состояние: Ожидание";
            }
            BuildGraph(); //формируем матрицу смежности получившегося графа
            Redraw(myNodes); //перерисовываем весь граф
        }
        private void deleteNodeBtn_Click(object sender, EventArgs e) //действия по удалению узлов
        {
            ClearStates();
            if (!String.IsNullOrEmpty(deleteTxt.Text))
            {
                string nodeValue = deleteTxt.Text;
                bool found = false;
                Node n = null;
                for (int i = 0; i < myNodes.Count; i++)
                {
                    if (myNodes[i].value == nodeValue)
                    {
                        found = true;
                        n = myNodes[i];
                        break;
                    }
                }
                if (found == true)
                {
                    Delete(n);
                } else
                {
                    MessageBox.Show("Узел не найден", "Ошибка");
                }
            } else
            {
                MessageBox.Show("Не выбран узел на удаление", "Ошибка");
            }
        }
        private void linkBtn_Click(object sender, EventArgs e) //действия по связыванию узлов
        {
            ClearStates();
            if (!String.IsNullOrEmpty(nodePickTxt.Text) && !String.IsNullOrEmpty(nodeLink2.Text))
            {
                string node1Value = nodePickTxt.Text;
                string node2Value = nodeLink2.Text;
                int lineLength = int.Parse(lengthNum.Value.ToString());
                int k = 0;
                Node node1=null, node2=null;
                for (int i = 0; i < myNodes.Count; i++)
                {
                    if (myNodes[i].value == node1Value)
                    {
                        node1 = myNodes[i];
                        k++;
                    }
                    if (myNodes[i].value == node2Value)
                    {
                        node2 = myNodes[i];
                        k++;
                    }
                }
                if (node1!=null && node2!=null && k == 2 && node1.value != node2.value) 
                {
                    if (node1.connected.Contains(node2)|| node2.connected.Contains(node1))
                    {
                        node1.lines[node1.connected.IndexOf(node2)].length = lineLength;
                        node2.lines[node2.connected.IndexOf(node1)].length = lineLength;
                        MessageBox.Show("Длина ребра изменена на "+lineLength,"Длина изменена",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BuildGraph();
                        Redraw(myNodes);
                    }else
                    {
                        Link(node1, node2, lineLength);
                    }
                }else
                {
                    MessageBox.Show("Узлы не найдены", "Ошибка");
                }
            } else
            {
                MessageBox.Show("Не выбраны узлы для связывания", "Ошибка");
            }
        }
        private void renameBtn_Click(object sender, EventArgs e) //действия по переименованию узлов
        {
            ClearStates();
            if (String.IsNullOrEmpty(curNameTxt.Text))
            {
                MessageBox.Show("Не выбран узел для переименования", "Ошибка");
                return;
            }
            string nodeValue = curNameTxt.Text;
            bool found = false;
            Node n = null;
            for (int i = 0; i < myNodes.Count; i++)
            {
                if (myNodes[i].value == nodeValue)
                {
                    found = true;
                    n = myNodes[i];
                    break;
                }
            }
            if (found == true)
            {
                if (!String.IsNullOrEmpty(newNameTxt.Text))
                {
                    bool ok = true;
                    for (int i = 0; i < myNodes.Count; i++)
                    {
                        if (myNodes[i].value == newNameTxt.Text)
                        {
                            ok = false;
                            break;
                        }
                    }
                    if (ok == true)
                    {
                        Rename(n, newNameTxt.Text);
                    }
                    else
                    {
                        MessageBox.Show("Узел с таким именем уже существует", "Ошибка");
                    }
                }
                else
                {
                    MessageBox.Show("Новое значение должно содержать хотя бы один символ", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Узел не найден", "Ошибка");
            }
        }
        private void redrawBtn_Click(object sender, EventArgs e) //убрать МОД с рисунка по кнопке
        {
            ClearMST();
        }
        public void Link(Node node1, Node node2, int length) //связывание узлов
        {
            Point startPoint = node1.center;
            Point listPoint = node2.center;
            float radius = circleSize / 2;
            if (startPoint != listPoint)
            {
                int X1 = listPoint.X;
                int X2 = startPoint.X;
                int Y1 = listPoint.Y;
                int Y2 = startPoint.Y;

                double angleStart = Math.Atan2(startPoint.Y - Y1, startPoint.X - X1);
                double angleEnd = Math.Atan2(listPoint.Y - Y2, listPoint.X - X2);

                float startX = X1 + Convert.ToSingle(radius * Math.Cos(angleStart));
                float startY = Y1 + Convert.ToSingle(radius * Math.Sin(angleStart));

                float endX = X2 + Convert.ToSingle(radius * Math.Cos(angleEnd));
                float endY = Y2 + Convert.ToSingle(radius * Math.Sin(angleEnd));

                graphics.DrawLine(pen, startX, startY, endX, endY);
                SolidBrush br = new SolidBrush(Color.Red);
                graphics.DrawString(length.ToString(), new Font("Times New Roman", 12), br, (startX+endX)/2, (startY + endY) / 2);
                int oper = 0;
                node1.Connect(node2, ref oper, length);
                node2.Connect(node1, ref oper, length);
                BuildGraph();
                pictureBox1.Image = map;
            }
        }
        public void Delete(Node node) //удаление узла
        {
            for (int i = 0; i < node.connected.Count; i++)
            {
                int index = node.connected[i].connected.IndexOf(node);
                node.connected[i].connected.RemoveAt(index);
                node.connected[i].lines.RemoveAt(index);
            }
            myNodes.RemoveAt(myNodes.IndexOf(node));
            BuildGraph();
            Redraw(myNodes);
        }
        public void Rename(Node node, string newText) //переименование узла
        {
            node.value = newText;
            BuildGraph();
            Redraw(myNodes);
        }
        public void ClearMST() //убирает МОД с рисунка
        {
            ClearStates();
            Redraw(myNodes);
            //tabControl2.SelectedIndex = 0;
            tableMod.Rows.Clear();
            minimumSpanningTree.Clear();
            connectors.Clear();
            weight.Text = "Вес=";
            label1.Text = "Количество операций:";
        }
        public void Redraw(List<Node> list, bool min = false) //перерисовывание графа
        {
            if (list != null)
            {
                if (min == false){ graphics.Clear(pictureBox1.BackColor); }
                for (int i = 0; i < list.Count; i++)
                {
                    float radius = circleSize / 2;
                    Point center = list[i].center;
                    Pen newPen;
                    if (min == false)
                    {
                        newPen = pen;
                    }else
                    {
                        newPen = new Pen(Color.Red, 3f);
                    }
                    graphics.DrawEllipse(newPen, center.X - radius, center.Y - radius, circleSize, circleSize);
                    SolidBrush br = new SolidBrush(newPen.Color);
                    graphics.DrawString(list[i].value, new Font("Times New Roman", 12), br, center.X - 5 - newPen.Width / 2, center.Y - 8 - newPen.Width / 2);
                    for (int j = 0; j < list[i].connected.Count; j++)
                    {
                        Point startPoint = list[i].center;
                        Point listPoint = list[i].connected[j].center;
                        int X1 = listPoint.X;
                        int X2 = startPoint.X;
                        int Y1 = listPoint.Y;
                        int Y2 = startPoint.Y;

                        double angleStart = Math.Atan2(startPoint.Y - Y1, startPoint.X - X1);
                        double angleEnd = Math.Atan2(listPoint.Y - Y2, listPoint.X - X2);

                        float startX = X1 + Convert.ToSingle(radius * Math.Cos(angleStart));
                        float startY = Y1 + Convert.ToSingle(radius * Math.Sin(angleStart));

                        float endX = X2 + Convert.ToSingle(radius * Math.Cos(angleEnd));
                        float endY = Y2 + Convert.ToSingle(radius * Math.Sin(angleEnd));

                        graphics.DrawLine(newPen, startX, startY, endX, endY);
                        SolidBrush br2;
                        if (min == false)
                        {
                            br2 = new SolidBrush(Color.Red);
                        } else
                        {
                            br2 = new SolidBrush(Color.Black);
                        }
                        
                        graphics.DrawString(list[i].lines[j].length.ToString(), new Font("Times New Roman", 12), br2, (startX + endX) / 2, (startY + endY) / 2);
                    }
                }
                pictureBox1.Image = map;
            }else
            {
                MessageBox.Show("Дерево не получилось", "Ошибка");
            }
        }
        private void createTree_Click(object sender, EventArgs e)
        {
            Algorhytms(comboBox1.SelectedIndex);
        }
        private void алгоритмПримаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Algorhytms(0);
        }
        private void алгоритмКрускалаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Algorhytms(1);
        }
        private void алгоритмБорувкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Algorhytms(2);
        }
        public void Algorhytms(int index) //построение МОД
        {
            ClearStates(); //очищение статусов
            ClearMST(); //удалить МОД, если оно уже построено
            if (myNodes.Count == 0)
            {
                MessageBox.Show("Нет узлов в графе", "Ошибка");
                return;
            }
            BuildGraph(); //сформировать таблицу смежности и вывести её на форму
            int[,] newMas = getMas(graph.mas);
            if (!isConnected(newMas,newMas.GetLength(0))) //проверка графа на связность
            {
                MessageBox.Show("Граф несвязный", "Ошибка");
                return;
            }
            else
            {
                connectors.Clear();
                List<Node> copyNodes = DeepCopy(myNodes); //создание глубокой копии списка узлов
                int oper = 0;
                switch (index) //формирование списка узлов МОД
                {
                    case 0: minimumSpanningTree = graph.primTree(copyNodes, weight, ref connectors, out oper); break;
                    case 1: minimumSpanningTree = graph.kraskTree(copyNodes, weight, ref connectors, out oper); break;
                    case 2: minimumSpanningTree = graph.boruvkaTree(copyNodes, weight, ref connectors, out oper); break;
                }
                label1.Text = "Количество операций: " + Environment.NewLine + oper.ToString();
                isMSTon = true;
                //graphics.Clear(pictureBox1.BackColor);
                Redraw(minimumSpanningTree, isMSTon); //вывод МОД на форму
                tabControl2.SelectedIndex = 1;
                tableMod.Rows.Clear();
                if (connectors.Count > 0) //вывод списка рёбер МОД
                {
                    for (int i = 0; i < connectors.Count; i++)
                    {
                        tableMod.Rows.Add(connectors[i].node1.value, connectors[i].node2.value, connectors[i].length);
                    }
                }
                Logging(connectors,index); //занесение данных в журнал
            }
        }
        public void Logging(List<Connecter> connectors, int index) //создание журнала действий пользователя
        {
            using (FileStream fs=new FileStream("../../../../journal.txt", FileMode.OpenOrCreate))
            {
                StreamWriter writer = new StreamWriter(fs);
                fs.Position = fs.Length;
                writer.Write("[" + DateTime.Now + "]");
                switch (index)
                {
                    case 0: writer.WriteLine(" Алгоритм Прима"); break;
                    case 1: writer.WriteLine(" Алгоритм Крускала"); break;
                    case 2: writer.WriteLine(" Алгоритм Борувки"); break;
                }
                int rows = graph.mas.GetLength(0);
                int cols = graph.mas.GetLength(1);
                writer.WriteLine("Таблица смежности графа:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        writer.Write("{0,6}", graph.mas[i, j]);
                    }
                    writer.WriteLine();
                }
                writer.WriteLine("МОД:");
                foreach (Connecter line in connectors)
                {
                    writer.WriteLine("\"" + line.node1.value + "\"  -> \"" + line.node2.value + "\" Вес: " + line.length);
                }
                writer.WriteLine(weight.Text);
                writer.Close();
            }
        }
        public List<Node> DeepCopy(List<Node> originalNodes) //создание глубокой копии списка
        {
            // Сериализация оригинального списка
            List<Node> copiedNodes = null;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Context = new StreamingContext(StreamingContextStates.Clone);
                formatter.Serialize(memoryStream, originalNodes);

                // Десериализация в новый объект
                memoryStream.Seek(0, SeekOrigin.Begin);
                copiedNodes = (List<Node>)formatter.Deserialize(memoryStream);
            }
            return copiedNodes;
        }
        public static bool isConnected(int[,] graph, int N) //проверка графа на связность
        {
            int[] status = new int[N];
            for (int i = 0; i < N; i++)
            {
                status[i] = 0;
            }
            int curr = 0;
            status[curr] = 1;
            Queue<int> que = new Queue<int>();
            que.Enqueue(curr); //добавили первую непосещённую вершину в очередь
            while (que.Count != 0)
            {
                curr = Convert.ToInt32(que.Dequeue()); //достаём из очереди вершину
                for (int j = 0; j < N; j++) //если вершина посещена, то продолжаем доставать вершины до тех пор, пока очередь не опустеет
                    if (graph[curr, j] != 0 && status[j] == 0) // если вершина не посещена и не 0
                    {
                        status[j] = 1; //то делаем её посещённой
                        que.Enqueue(j); //и заносим в очередь
                    }
            }
            if (end(status))
                return true;
            else
                return false;
        }
        public static bool end(int[] status) //закончена ли проверка на связность
        {
            bool f = true;
            for (int i = 0; i < status.Length; i++)
                if (status[i] == 0)
                    f = false;
            return f;
        }
        public static int[,] getMas(int[,] mas) //метод для извлечения таблицы смежности из исходной таблицы
        {
            int[,] newmas = new int[mas.GetLength(0) - 1, mas.GetLength(0) - 1];
            for (int i = 1; i < mas.GetLength(0); i++)
            {
                for (int j = 1; j < mas.GetLength(0); j++)
                {
                    newmas[i-1,j-1] = mas[i, j];
                }
            }
            return newmas;
        }
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e) //запрет ввода текста
        {
            e.Handled = true;
        }
        public Bitmap SavePictureBoxContent() //сохранение содержимого холста
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                pictureBox1.DrawToBitmap(bitmap, pictureBox1.ClientRectangle);
                pictureBox1.Image = bitmap;
            }
            return bitmap;
        }
        private void графToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Title = "Сохранить картинку как ...";
                saveFileDialog1.Filter = "PNG File(*.png)|*.png|" + "JPEG File(*.jpg)|*.jpg";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog1.FileName;
                    if (string.IsNullOrEmpty(fileName))
                    {
                        throw (new Exceptions("Имя файла не может быть пустым!"));
                    }
                    string strFilExtn = fileName.Remove(0, fileName.Length - 3);
                    switch (strFilExtn)
                    {
                        case "jpg": SavePictureBoxContent().Save(fileName, ImageFormat.Jpeg); break;
                        case "png": SavePictureBoxContent().Save(fileName, ImageFormat.Png); break;
                        default: break;
                    }
                }
            }
            catch (Exceptions ex)
            {
                MessageBox.Show(ex.Message, "Ошибка1");
            }
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка2");
			}
		}
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (myNodes.Count > 0)
                {
                    saveFileDialog1.Title = "Сохранить граф как ...";
                    saveFileDialog1.Filter = "GRP File(*.grp)|*.grp";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string fileName = saveFileDialog1.FileName;
                        if (string.IsNullOrEmpty(fileName))
                        {
                            throw (new Exceptions("Имя файла не может быть пустым!"));
                        }
                        List<Node> helper = new List<Node>(myNodes);
                        SaveGraphToFile(myNodes, fileName);
                    }
                }else
                {
                    MessageBox.Show("Граф пустой", "Ошибка");
                }
            }
            catch (Exceptions ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
        private void SaveGraphToFile(List<Node> nodes, string fileName) //сохранение графа в двоичный файл
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, nodes);
            }
        }
        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "GRP File(*.grp)|*.grp";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    myNodes = LoadGraphFromFile(openFileDialog1.FileName);
                    kolvo = myNodes.Count();
                    BuildGraph();
                    tableMod.Rows.Clear();
                    weight.Text = "Вес=";
                    label1.Text = "Количество операций: ";
                    Redraw(myNodes);
                }
            }
            catch (Exceptions ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
        private List<Node> LoadGraphFromFile(string fileName) //загрузить граф из двоичного файла
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (List<Node>)formatter.Deserialize(fs);
            }
        }
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info f = new Info();
            f.Show();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            SetSize();
            Redraw(myNodes);
        }

        private void panel4_Resize(object sender, EventArgs e)
        {
            ResizeObj(label8);
            ResizeObj(comboBox1);
            ResizeObj(createTree);
            ResizeObj(redrawBtn);
        }
        public void ResizeObj(Control ctrl)
        {
            Point p = ctrl.Location;
            p.X = panel4.Width / 2 - ctrl.Width / 2;
            ctrl.Location = p;
        }
        public bool isHovering(Point point, List<Node> list) //перекрывает ли новый узел существующий узел
        {
            int k = 0;
            helperLable.Text = "Состояние: Ожидание";
            for (int i = 0; i < list.Count; i++)
            {
                Point listPoint = list[i].center;
                double dist = Math.Sqrt(Math.Abs(Math.Pow((listPoint.X - point.X), 2) + Math.Pow((listPoint.Y - point.Y),2)));
                if (dist < circleSize)
                {
                    k++;
                }
            }
            if (k > 0)
            {
                return true;
            }
            else{
                return false;
            }
        }
        public void ClearStates()
        {
            deletingState = false;
            addingState = false;
            connectingState = false;
            helperLable.Text = "Состояние: Ожидание";
            isMSTon = false;
        }
        public void BuildGraph() //преобразование списка узлов в таблицу смежности и её вывод на форму
        {
            int oper = 0;
            foreach(Node node in myNodes)
            {
                node.findShortest(node.connected,node.lines, ref oper);
            }
            graph.newGraph(myNodes);
            graph.masOut(tableGraph);
        }
    }
}
