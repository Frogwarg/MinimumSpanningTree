
namespace MinimumSpanningTree
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addNodeBtn = new System.Windows.Forms.Button();
            this.connectBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.графToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.алгоритмыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.алгоритмПримаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.алгоритмКрускалаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.алгоритмБорувкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.redrawBtn = new System.Windows.Forms.Button();
            this.createTree = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableGraph = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tableMod = new System.Windows.Forms.DataGridView();
            this.weight = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lengthNum = new System.Windows.Forms.NumericUpDown();
            this.linkBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nodePickLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nodePickTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nodeLink2 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.deleteTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteNodeBtn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.renameBtn = new System.Windows.Forms.Button();
            this.newNameTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.curNameTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.delNodeBtn = new System.Windows.Forms.Button();
            this.helperLable = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableGraph)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableMod)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthNum)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addNodeBtn
            // 
            this.addNodeBtn.Location = new System.Drawing.Point(18, 44);
            this.addNodeBtn.Name = "addNodeBtn";
            this.addNodeBtn.Size = new System.Drawing.Size(155, 23);
            this.addNodeBtn.TabIndex = 0;
            this.addNodeBtn.Text = "Добавить вершину";
            this.addNodeBtn.UseVisualStyleBackColor = true;
            this.addNodeBtn.Click += new System.EventHandler(this.addNodeBtn_Click);
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(40, 76);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(107, 23);
            this.connectBtn.TabIndex = 1;
            this.connectBtn.Text = "Связать вершины";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.графToolStripMenuItem,
            this.алгоритмыToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(1068, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // графToolStripMenuItem
            // 
            this.графToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьФайлToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.очиститьToolStripMenuItem});
            this.графToolStripMenuItem.Name = "графToolStripMenuItem";
            this.графToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.графToolStripMenuItem.Text = "Граф";
            // 
            // открытьФайлToolStripMenuItem
            // 
            this.открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            this.открытьФайлToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.открытьФайлToolStripMenuItem.Text = "Открыть файл...";
            this.открытьФайлToolStripMenuItem.Click += new System.EventHandler(this.открытьФайлToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.графToolStripMenuItem1,
            this.fileToolStripMenuItem});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить как...";
            // 
            // графToolStripMenuItem1
            // 
            this.графToolStripMenuItem1.Name = "графToolStripMenuItem1";
            this.графToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.графToolStripMenuItem1.Text = "Изображение";
            this.графToolStripMenuItem1.Click += new System.EventHandler(this.графToolStripMenuItem1_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.fileToolStripMenuItem.Text = "Двоичный файл";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click_1);
            // 
            // алгоритмыToolStripMenuItem
            // 
            this.алгоритмыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.алгоритмПримаToolStripMenuItem,
            this.алгоритмКрускалаToolStripMenuItem,
            this.алгоритмБорувкиToolStripMenuItem});
            this.алгоритмыToolStripMenuItem.Name = "алгоритмыToolStripMenuItem";
            this.алгоритмыToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.алгоритмыToolStripMenuItem.Text = "Алгоритмы";
            // 
            // алгоритмПримаToolStripMenuItem
            // 
            this.алгоритмПримаToolStripMenuItem.Name = "алгоритмПримаToolStripMenuItem";
            this.алгоритмПримаToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.алгоритмПримаToolStripMenuItem.Text = "Алгоритм Прима";
            this.алгоритмПримаToolStripMenuItem.Click += new System.EventHandler(this.алгоритмПримаToolStripMenuItem_Click);
            // 
            // алгоритмКрускалаToolStripMenuItem
            // 
            this.алгоритмКрускалаToolStripMenuItem.Name = "алгоритмКрускалаToolStripMenuItem";
            this.алгоритмКрускалаToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.алгоритмКрускалаToolStripMenuItem.Text = "Алгоритм Крускала";
            this.алгоритмКрускалаToolStripMenuItem.Click += new System.EventHandler(this.алгоритмКрускалаToolStripMenuItem_Click);
            // 
            // алгоритмБорувкиToolStripMenuItem
            // 
            this.алгоритмБорувкиToolStripMenuItem.Name = "алгоритмБорувкиToolStripMenuItem";
            this.алгоритмБорувкиToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.алгоритмБорувкиToolStripMenuItem.Text = "Алгоритм Борувки";
            this.алгоритмБорувкиToolStripMenuItem.Click += new System.EventHandler(this.алгоритмБорувкиToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 223);
            this.panel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.tabControl2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(408, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 223);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Минимальное остовное дерево";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.redrawBtn);
            this.panel4.Controls.Add(this.createTree);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(230, 204);
            this.panel4.TabIndex = 0;
            this.panel4.Resize += new System.EventHandler(this.panel4_Resize);
            // 
            // redrawBtn
            // 
            this.redrawBtn.Location = new System.Drawing.Point(63, 122);
            this.redrawBtn.Name = "redrawBtn";
            this.redrawBtn.Size = new System.Drawing.Size(92, 23);
            this.redrawBtn.TabIndex = 11;
            this.redrawBtn.Text = "Удалить МОД";
            this.redrawBtn.UseVisualStyleBackColor = true;
            this.redrawBtn.Click += new System.EventHandler(this.redrawBtn_Click);
            // 
            // createTree
            // 
            this.createTree.Location = new System.Drawing.Point(29, 87);
            this.createTree.Name = "createTree";
            this.createTree.Size = new System.Drawing.Size(160, 29);
            this.createTree.TabIndex = 7;
            this.createTree.Text = "Построить МОД";
            this.createTree.UseVisualStyleBackColor = true;
            this.createTree.Click += new System.EventHandler(this.createTree_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Прима",
            "Крускала",
            "Борувки"});
            this.comboBox1.Location = new System.Drawing.Point(51, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Алгоритм:";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl2.Location = new System.Drawing.Point(233, 16);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(424, 204);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableGraph);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(416, 178);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Таблица смежности";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableGraph
            // 
            this.tableGraph.AllowUserToAddRows = false;
            this.tableGraph.AllowUserToDeleteRows = false;
            this.tableGraph.AllowUserToResizeColumns = false;
            this.tableGraph.AllowUserToResizeRows = false;
            this.tableGraph.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tableGraph.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tableGraph.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableGraph.Location = new System.Drawing.Point(6, 6);
            this.tableGraph.Name = "tableGraph";
            this.tableGraph.Size = new System.Drawing.Size(403, 177);
            this.tableGraph.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.tableMod);
            this.tabPage5.Controls.Add(this.weight);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(416, 178);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "МОД";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(271, 42);
            this.label1.MaximumSize = new System.Drawing.Size(150, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 40);
            this.label1.TabIndex = 16;
            this.label1.Text = "Количество операций:";
            // 
            // tableMod
            // 
            this.tableMod.AllowUserToAddRows = false;
            this.tableMod.AllowUserToDeleteRows = false;
            this.tableMod.AllowUserToResizeColumns = false;
            this.tableMod.AllowUserToResizeRows = false;
            this.tableMod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tableMod.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tableMod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableMod.Location = new System.Drawing.Point(6, 12);
            this.tableMod.Name = "tableMod";
            this.tableMod.Size = new System.Drawing.Size(245, 158);
            this.tableMod.TabIndex = 15;
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weight.Location = new System.Drawing.Point(271, 12);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(46, 20);
            this.weight.TabIndex = 14;
            this.weight.Text = "Вес=";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClearBtn);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.delNodeBtn);
            this.groupBox1.Controls.Add(this.addNodeBtn);
            this.groupBox1.Controls.Add(this.connectBtn);
            this.groupBox1.Controls.Add(this.helperLable);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 223);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Инструменты";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(55, 140);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 11;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(185, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(208, 193);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.lengthNum);
            this.tabPage1.Controls.Add(this.linkBtn);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.nodePickLabel);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.nodePickTxt);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.nodeLink2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(200, 167);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Связывание";
            // 
            // lengthNum
            // 
            this.lengthNum.Location = new System.Drawing.Point(84, 119);
            this.lengthNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.lengthNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lengthNum.Name = "lengthNum";
            this.lengthNum.Size = new System.Drawing.Size(85, 20);
            this.lengthNum.TabIndex = 14;
            this.lengthNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // linkBtn
            // 
            this.linkBtn.Location = new System.Drawing.Point(59, 72);
            this.linkBtn.Name = "linkBtn";
            this.linkBtn.Size = new System.Drawing.Size(75, 23);
            this.linkBtn.TabIndex = 10;
            this.linkBtn.Text = "Связать";
            this.linkBtn.UseVisualStyleBackColor = true;
            this.linkBtn.Click += new System.EventHandler(this.linkBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Длина:";
            // 
            // nodePickLabel
            // 
            this.nodePickLabel.AutoSize = true;
            this.nodePickLabel.Location = new System.Drawing.Point(18, 16);
            this.nodePickLabel.Name = "nodePickLabel";
            this.nodePickLabel.Size = new System.Drawing.Size(64, 13);
            this.nodePickLabel.TabIndex = 4;
            this.nodePickLabel.Text = "Вершина 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "+";
            // 
            // nodePickTxt
            // 
            this.nodePickTxt.Location = new System.Drawing.Point(21, 32);
            this.nodePickTxt.Name = "nodePickTxt";
            this.nodePickTxt.Size = new System.Drawing.Size(60, 20);
            this.nodePickTxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Вершина 2:";
            // 
            // nodeLink2
            // 
            this.nodeLink2.Location = new System.Drawing.Point(115, 31);
            this.nodeLink2.Name = "nodeLink2";
            this.nodeLink2.Size = new System.Drawing.Size(61, 20);
            this.nodeLink2.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.deleteTxt);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.deleteNodeBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(200, 167);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Удаление";
            // 
            // deleteTxt
            // 
            this.deleteTxt.Location = new System.Drawing.Point(44, 54);
            this.deleteTxt.Name = "deleteTxt";
            this.deleteTxt.Size = new System.Drawing.Size(100, 20);
            this.deleteTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вершина:";
            // 
            // deleteNodeBtn
            // 
            this.deleteNodeBtn.Location = new System.Drawing.Point(60, 96);
            this.deleteNodeBtn.Name = "deleteNodeBtn";
            this.deleteNodeBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteNodeBtn.TabIndex = 0;
            this.deleteNodeBtn.Text = "Удалить";
            this.deleteNodeBtn.UseVisualStyleBackColor = true;
            this.deleteNodeBtn.Click += new System.EventHandler(this.deleteNodeBtn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.renameBtn);
            this.tabPage3.Controls.Add(this.newNameTxt);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.curNameTxt);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(200, 167);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Название";
            // 
            // renameBtn
            // 
            this.renameBtn.Location = new System.Drawing.Point(46, 105);
            this.renameBtn.Name = "renameBtn";
            this.renameBtn.Size = new System.Drawing.Size(104, 23);
            this.renameBtn.TabIndex = 4;
            this.renameBtn.Text = "Переименовать";
            this.renameBtn.UseVisualStyleBackColor = true;
            this.renameBtn.Click += new System.EventHandler(this.renameBtn_Click);
            // 
            // newNameTxt
            // 
            this.newNameTxt.Location = new System.Drawing.Point(111, 51);
            this.newNameTxt.Name = "newNameTxt";
            this.newNameTxt.Size = new System.Drawing.Size(69, 20);
            this.newNameTxt.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Новое:";
            // 
            // curNameTxt
            // 
            this.curNameTxt.Location = new System.Drawing.Point(15, 51);
            this.curNameTxt.Name = "curNameTxt";
            this.curNameTxt.Size = new System.Drawing.Size(69, 20);
            this.curNameTxt.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Текущее:";
            // 
            // delNodeBtn
            // 
            this.delNodeBtn.Location = new System.Drawing.Point(40, 111);
            this.delNodeBtn.Name = "delNodeBtn";
            this.delNodeBtn.Size = new System.Drawing.Size(107, 23);
            this.delNodeBtn.TabIndex = 8;
            this.delNodeBtn.Text = "Удалить вершину";
            this.delNodeBtn.UseVisualStyleBackColor = true;
            this.delNodeBtn.Click += new System.EventHandler(this.delNodeBtn_Click);
            // 
            // helperLable
            // 
            this.helperLable.AutoSize = true;
            this.helperLable.Location = new System.Drawing.Point(6, 197);
            this.helperLable.Name = "helperLable";
            this.helperLable.Size = new System.Drawing.Size(119, 13);
            this.helperLable.TabIndex = 2;
            this.helperLable.Text = "Состояние: Ожидание";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1068, 459);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LoadBtn);
            this.panel3.Controls.Add(this.SaveBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 426);
            this.panel3.MaximumSize = new System.Drawing.Size(171, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 29);
            this.panel3.TabIndex = 2;
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(90, 3);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadBtn.TabIndex = 1;
            this.LoadBtn.Text = "Загрузить";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.открытьФайлToolStripMenuItem_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(3, 3);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1064, 455);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 706);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1084, 698);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рабочая область";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableGraph)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableMod)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthNum)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNodeBtn;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem графToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label helperLable;
        private System.Windows.Forms.Label nodePickLabel;
        private System.Windows.Forms.TextBox nodePickTxt;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графToolStripMenuItem1;
        private System.Windows.Forms.Button createTree;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button linkBtn;
        private System.Windows.Forms.TextBox nodeLink2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown lengthNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox deleteTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteNodeBtn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button renameBtn;
        private System.Windows.Forms.TextBox newNameTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox curNameTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button redrawBtn;
        private System.Windows.Forms.Button delNodeBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView tableGraph;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.DataGridView tableMod;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem алгоритмыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem алгоритмПримаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem алгоритмКрускалаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem алгоритмБорувкиToolStripMenuItem;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel4;
    }
}

