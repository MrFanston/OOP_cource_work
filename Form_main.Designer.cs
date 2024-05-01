namespace OOP_Course_work
{
    partial class Form_main
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Узел10");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("СО2-лазер", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Узел11");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Филаментный", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Узел12");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Фотополимерный", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("3D-принтер", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Обрабатываемые", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Узел13");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Необрабатываемые", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Products = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_warehouse = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.tabPage_Materials = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_use = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.treeView_materials = new System.Windows.Forms.TreeView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage_Analysis = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label10 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage_Products.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel_warehouse.SuspendLayout();
            this.tabPage_Materials.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel_use.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage_Analysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Products);
            this.tabControl1.Controls.Add(this.tabPage_Materials);
            this.tabControl1.Controls.Add(this.tabPage_Analysis);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1068, 558);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_Products
            // 
            this.tabPage_Products.BackColor = System.Drawing.SystemColors.Info;
            this.tabPage_Products.Controls.Add(this.label7);
            this.tabPage_Products.Controls.Add(this.panel4);
            this.tabPage_Products.Controls.Add(this.label6);
            this.tabPage_Products.Controls.Add(this.panel1);
            this.tabPage_Products.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Products.Name = "tabPage_Products";
            this.tabPage_Products.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Products.Size = new System.Drawing.Size(1060, 529);
            this.tabPage_Products.TabIndex = 0;
            this.tabPage_Products.Text = "Товары";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(652, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Информация о товаре";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Tan;
            this.panel4.Location = new System.Drawing.Point(505, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(528, 467);
            this.panel4.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(135, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Товары на складе";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel_warehouse);
            this.panel1.Location = new System.Drawing.Point(40, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 468);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel_warehouse
            // 
            this.tableLayoutPanel_warehouse.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel_warehouse.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel_warehouse.ColumnCount = 3;
            this.tableLayoutPanel_warehouse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.90323F));
            this.tableLayoutPanel_warehouse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.90029F));
            this.tableLayoutPanel_warehouse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.35632F));
            this.tableLayoutPanel_warehouse.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel_warehouse.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel_warehouse.Controls.Add(this.button_add, 0, 0);
            this.tableLayoutPanel_warehouse.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_warehouse.Name = "tableLayoutPanel_warehouse";
            this.tableLayoutPanel_warehouse.RowCount = 1;
            this.tableLayoutPanel_warehouse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel_warehouse.Size = new System.Drawing.Size(343, 50);
            this.tableLayoutPanel_warehouse.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(301, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "...";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(50, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фанера 4/4 4мм";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_add
            // 
            this.button_add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_add.BackColor = System.Drawing.Color.Lime;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(5, 5);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(37, 38);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "+";
            this.button_add.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // tabPage_Materials
            // 
            this.tabPage_Materials.AutoScroll = true;
            this.tabPage_Materials.BackColor = System.Drawing.SystemColors.Info;
            this.tabPage_Materials.Controls.Add(this.panel3);
            this.tabPage_Materials.Controls.Add(this.panel2);
            this.tabPage_Materials.Controls.Add(this.label5);
            this.tabPage_Materials.Controls.Add(this.label4);
            this.tabPage_Materials.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Materials.Name = "tabPage_Materials";
            this.tabPage_Materials.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Materials.Size = new System.Drawing.Size(1060, 529);
            this.tabPage_Materials.TabIndex = 1;
            this.tabPage_Materials.Text = "Материалы";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.Tan;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tableLayoutPanel_use);
            this.panel3.Location = new System.Drawing.Point(594, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(372, 468);
            this.panel3.TabIndex = 3;
            // 
            // tableLayoutPanel_use
            // 
            this.tableLayoutPanel_use.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel_use.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel_use.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel_use.ColumnCount = 3;
            this.tableLayoutPanel_use.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.90323F));
            this.tableLayoutPanel_use.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.90029F));
            this.tableLayoutPanel_use.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.35632F));
            this.tableLayoutPanel_use.Controls.Add(this.button4, 2, 0);
            this.tableLayoutPanel_use.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel_use.Controls.Add(this.button5, 0, 0);
            this.tableLayoutPanel_use.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_use.Name = "tableLayoutPanel_use";
            this.tableLayoutPanel_use.RowCount = 1;
            this.tableLayoutPanel_use.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel_use.Size = new System.Drawing.Size(343, 50);
            this.tableLayoutPanel_use.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.BackColor = System.Drawing.Color.LightGray;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(301, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 38);
            this.button4.TabIndex = 2;
            this.button4.Text = "...";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(50, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Пластик ABS черный";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button5.BackColor = System.Drawing.Color.Lime;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(5, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(37, 38);
            this.button5.TabIndex = 1;
            this.button5.Text = "+";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_add_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.treeView_materials);
            this.panel2.Location = new System.Drawing.Point(67, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 468);
            this.panel2.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 34);
            this.button3.TabIndex = 1;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // treeView_materials
            // 
            this.treeView_materials.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView_materials.Location = new System.Drawing.Point(3, 3);
            this.treeView_materials.Name = "treeView_materials";
            treeNode1.Name = "Узел10";
            treeNode1.Text = "Узел10";
            treeNode2.Name = "Узел2";
            treeNode2.Text = "СО2-лазер";
            treeNode3.Name = "Узел11";
            treeNode3.Text = "Узел11";
            treeNode4.Name = "Узел4";
            treeNode4.Text = "Филаментный";
            treeNode5.Name = "Узел12";
            treeNode5.Text = "Узел12";
            treeNode6.Name = "Узел5";
            treeNode6.Text = "Фотополимерный";
            treeNode7.Name = "Узел3";
            treeNode7.Text = "3D-принтер";
            treeNode8.Name = "Узел0";
            treeNode8.Text = "Обрабатываемые";
            treeNode9.Name = "Узел13";
            treeNode9.Text = "Узел13";
            treeNode10.Name = "Узел1";
            treeNode10.Text = "Необрабатываемые";
            this.treeView_materials.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode10});
            this.treeView_materials.Size = new System.Drawing.Size(364, 420);
            this.treeView_materials.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(645, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Материалы используемые";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(158, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Материалы на складе";
            // 
            // tabPage_Analysis
            // 
            this.tabPage_Analysis.BackColor = System.Drawing.SystemColors.Info;
            this.tabPage_Analysis.Controls.Add(this.label11);
            this.tabPage_Analysis.Controls.Add(this.button1);
            this.tabPage_Analysis.Controls.Add(this.chart1);
            this.tabPage_Analysis.Controls.Add(this.label10);
            this.tabPage_Analysis.Controls.Add(this.listView2);
            this.tabPage_Analysis.Controls.Add(this.label2);
            this.tabPage_Analysis.Controls.Add(this.listView1);
            this.tabPage_Analysis.Controls.Add(this.label9);
            this.tabPage_Analysis.Controls.Add(this.label8);
            this.tabPage_Analysis.Controls.Add(this.dateTimePicker2);
            this.tabPage_Analysis.Controls.Add(this.dateTimePicker1);
            this.tabPage_Analysis.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Analysis.Name = "tabPage_Analysis";
            this.tabPage_Analysis.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Analysis.Size = new System.Drawing.Size(1060, 529);
            this.tabPage_Analysis.TabIndex = 2;
            this.tabPage_Analysis.Text = "Анализ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(134, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 24);
            this.label11.TabIndex = 12;
            this.label11.Text = "Прогнозирование";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(289, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Расчет";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(13, 132);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(381, 385);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(840, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "Списания";
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(737, 49);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(306, 473);
            this.listView2.TabIndex = 7;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(502, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Поступления";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(413, 49);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(306, 473);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "№";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Поступление";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Комментарий";
            this.columnHeader3.Width = 172;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(16, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "До";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(16, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "От";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(50, 65);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(50, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_main";
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Products.ResumeLayout(false);
            this.tabPage_Products.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel_warehouse.ResumeLayout(false);
            this.tableLayoutPanel_warehouse.PerformLayout();
            this.tabPage_Materials.ResumeLayout(false);
            this.tabPage_Materials.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel_use.ResumeLayout(false);
            this.tableLayoutPanel_use.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabPage_Analysis.ResumeLayout(false);
            this.tabPage_Analysis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Products;
        private System.Windows.Forms.TabPage tabPage_Materials;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_warehouse;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage_Analysis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_use;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TreeView treeView_materials;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button3;
    }
}

