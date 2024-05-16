using Aspose.Cells;

namespace OOP_Course_work
{
    partial class MainForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("СО2-лазер", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Филаментный", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Фотополимерный", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("3D-принтер", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Обрабатываемые", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Необрабатываемые", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Products = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.richTextBox_description = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_products = new System.Windows.Forms.TableLayoutPanel();
            this.button_description = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_Materials = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_use_materials = new System.Windows.Forms.TableLayoutPanel();
            this.button_add_use_maaterials = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_new_material = new System.Windows.Forms.Button();
            this.treeView_warehouse_materials = new System.Windows.Forms.TreeView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage_Analysis = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.button_sort = new System.Windows.Forms.Button();
            this.chart_extrapolation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label10 = new System.Windows.Forms.Label();
            this.listView_write_off = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.listView_admission = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker_right = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_left = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage_Products.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel_products.SuspendLayout();
            this.tabPage_Materials.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel_use_materials.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage_Analysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_extrapolation)).BeginInit();
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
            this.panel4.Controls.Add(this.richTextBox_description);
            this.panel4.Location = new System.Drawing.Point(505, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(528, 467);
            this.panel4.TabIndex = 4;
            // 
            // richTextBox_description
            // 
            this.richTextBox_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_description.Location = new System.Drawing.Point(3, 4);
            this.richTextBox_description.Name = "richTextBox_description";
            this.richTextBox_description.Size = new System.Drawing.Size(522, 460);
            this.richTextBox_description.TabIndex = 0;
            this.richTextBox_description.Text = "";
            this.richTextBox_description.Visible = false;
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
            this.panel1.Controls.Add(this.tableLayoutPanel_products);
            this.panel1.Location = new System.Drawing.Point(40, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 468);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel_products
            // 
            this.tableLayoutPanel_products.AutoSize = true;
            this.tableLayoutPanel_products.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel_products.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel_products.ColumnCount = 3;
            this.tableLayoutPanel_products.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.01256F));
            this.tableLayoutPanel_products.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.52643F));
            this.tableLayoutPanel_products.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.46101F));
            this.tableLayoutPanel_products.Controls.Add(this.button_description, 2, 0);
            this.tableLayoutPanel_products.Controls.Add(this.button_add, 0, 0);
            this.tableLayoutPanel_products.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel_products.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_products.Name = "tableLayoutPanel_products";
            this.tableLayoutPanel_products.RowCount = 1;
            this.tableLayoutPanel_products.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_products.Size = new System.Drawing.Size(363, 50);
            this.tableLayoutPanel_products.TabIndex = 0;
            // 
            // button_description
            // 
            this.button_description.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_description.BackColor = System.Drawing.Color.LightGray;
            this.button_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_description.ForeColor = System.Drawing.Color.Black;
            this.button_description.Location = new System.Drawing.Point(320, 5);
            this.button_description.Name = "button_description";
            this.button_description.Size = new System.Drawing.Size(37, 38);
            this.button_description.TabIndex = 2;
            this.button_description.Text = "...";
            this.button_description.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_description.UseVisualStyleBackColor = false;
            this.button_description.Visible = false;
            this.button_description.Click += new System.EventHandler(this.button_description_Click);
            // 
            // button_add
            // 
            this.button_add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_add.BackColor = System.Drawing.Color.Lime;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(6, 5);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(37, 38);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "+";
            this.button_add.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(53, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фанера 4/4 4мм";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Visible = false;
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
            this.panel3.Controls.Add(this.tableLayoutPanel_use_materials);
            this.panel3.Location = new System.Drawing.Point(594, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(372, 468);
            this.panel3.TabIndex = 3;
            // 
            // tableLayoutPanel_use_materials
            // 
            this.tableLayoutPanel_use_materials.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel_use_materials.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel_use_materials.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel_use_materials.ColumnCount = 2;
            this.tableLayoutPanel_use_materials.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.90281F));
            this.tableLayoutPanel_use_materials.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.09719F));
            this.tableLayoutPanel_use_materials.Controls.Add(this.button_add_use_maaterials, 0, 0);
            this.tableLayoutPanel_use_materials.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_use_materials.Name = "tableLayoutPanel_use_materials";
            this.tableLayoutPanel_use_materials.RowCount = 1;
            this.tableLayoutPanel_use_materials.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_use_materials.Size = new System.Drawing.Size(343, 50);
            this.tableLayoutPanel_use_materials.TabIndex = 0;
            // 
            // button_add_use_maaterials
            // 
            this.button_add_use_maaterials.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_add_use_maaterials.BackColor = System.Drawing.Color.Gray;
            this.button_add_use_maaterials.Enabled = false;
            this.button_add_use_maaterials.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add_use_maaterials.Location = new System.Drawing.Point(5, 5);
            this.button_add_use_maaterials.Name = "button_add_use_maaterials";
            this.button_add_use_maaterials.Size = new System.Drawing.Size(37, 38);
            this.button_add_use_maaterials.TabIndex = 1;
            this.button_add_use_maaterials.Text = "+";
            this.button_add_use_maaterials.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_add_use_maaterials.UseVisualStyleBackColor = false;
            this.button_add_use_maaterials.Click += new System.EventHandler(this.button_add_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button_new_material);
            this.panel2.Controls.Add(this.treeView_warehouse_materials);
            this.panel2.Location = new System.Drawing.Point(67, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 468);
            this.panel2.TabIndex = 7;
            // 
            // button_new_material
            // 
            this.button_new_material.Location = new System.Drawing.Point(3, 429);
            this.button_new_material.Name = "button_new_material";
            this.button_new_material.Size = new System.Drawing.Size(96, 34);
            this.button_new_material.TabIndex = 1;
            this.button_new_material.Text = "Добавить";
            this.button_new_material.UseVisualStyleBackColor = true;
            this.button_new_material.Click += new System.EventHandler(this.button_new_material_Click);
            // 
            // treeView_warehouse_materials
            // 
            this.treeView_warehouse_materials.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView_warehouse_materials.Location = new System.Drawing.Point(3, 3);
            this.treeView_warehouse_materials.Name = "treeView_warehouse_materials";
            treeNode1.Name = "Узел3";
            treeNode1.Text = "";
            treeNode2.Name = "laser";
            treeNode2.Text = "СО2-лазер";
            treeNode3.Name = "Узел4";
            treeNode3.Text = "";
            treeNode4.Name = "fdm";
            treeNode4.Text = "Филаментный";
            treeNode5.Name = "Узел5";
            treeNode5.Text = "";
            treeNode6.Name = "sla";
            treeNode6.Text = "Фотополимерный";
            treeNode7.Name = "printer";
            treeNode7.Text = "3D-принтер";
            treeNode8.Name = "processed";
            treeNode8.Text = "Обрабатываемые";
            treeNode9.Name = "Узел2";
            treeNode9.Text = "";
            treeNode10.Name = "no_processed";
            treeNode10.Text = "Необрабатываемые";
            this.treeView_warehouse_materials.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode10});
            this.treeView_warehouse_materials.Size = new System.Drawing.Size(364, 420);
            this.treeView_warehouse_materials.TabIndex = 0;
            this.treeView_warehouse_materials.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_warehouse_materials_NodeMouseClick);
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
            this.tabPage_Analysis.Controls.Add(this.button_sort);
            this.tabPage_Analysis.Controls.Add(this.chart_extrapolation);
            this.tabPage_Analysis.Controls.Add(this.label10);
            this.tabPage_Analysis.Controls.Add(this.listView_write_off);
            this.tabPage_Analysis.Controls.Add(this.label2);
            this.tabPage_Analysis.Controls.Add(this.listView_admission);
            this.tabPage_Analysis.Controls.Add(this.label9);
            this.tabPage_Analysis.Controls.Add(this.label8);
            this.tabPage_Analysis.Controls.Add(this.dateTimePicker_right);
            this.tabPage_Analysis.Controls.Add(this.dateTimePicker_left);
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
            // button_sort
            // 
            this.button_sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_sort.Location = new System.Drawing.Point(289, 47);
            this.button_sort.Name = "button_sort";
            this.button_sort.Size = new System.Drawing.Size(76, 33);
            this.button_sort.TabIndex = 11;
            this.button_sort.Text = "Расчет";
            this.button_sort.UseVisualStyleBackColor = true;
            this.button_sort.Click += new System.EventHandler(this.button_sort_Click);
            // 
            // chart_extrapolation
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_extrapolation.ChartAreas.Add(chartArea1);
            this.chart_extrapolation.Location = new System.Drawing.Point(13, 132);
            this.chart_extrapolation.Name = "chart_extrapolation";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chart_extrapolation.Series.Add(series1);
            this.chart_extrapolation.Size = new System.Drawing.Size(381, 385);
            this.chart_extrapolation.TabIndex = 10;
            this.chart_extrapolation.Text = "chart1";
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
            // listView_write_off
            // 
            this.listView_write_off.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView_write_off.HideSelection = false;
            this.listView_write_off.Location = new System.Drawing.Point(737, 49);
            this.listView_write_off.Name = "listView_write_off";
            this.listView_write_off.Size = new System.Drawing.Size(306, 473);
            this.listView_write_off.TabIndex = 7;
            this.listView_write_off.UseCompatibleStateImageBehavior = false;
            this.listView_write_off.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "№";
            this.columnHeader4.Width = 30;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Списание";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Комментарий";
            this.columnHeader6.Width = 1000;
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
            // listView_admission
            // 
            this.listView_admission.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_admission.HideSelection = false;
            this.listView_admission.Location = new System.Drawing.Point(413, 49);
            this.listView_admission.Name = "listView_admission";
            this.listView_admission.Size = new System.Drawing.Size(306, 473);
            this.listView_admission.TabIndex = 5;
            this.listView_admission.UseCompatibleStateImageBehavior = false;
            this.listView_admission.View = System.Windows.Forms.View.Details;
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
            this.columnHeader3.Width = 1000;
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
            // dateTimePicker_right
            // 
            this.dateTimePicker_right.Location = new System.Drawing.Point(50, 65);
            this.dateTimePicker_right.Name = "dateTimePicker_right";
            this.dateTimePicker_right.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker_right.TabIndex = 2;
            this.dateTimePicker_right.Value = new System.DateTime(2024, 5, 20, 11, 27, 0, 0);
            // 
            // dateTimePicker_left
            // 
            this.dateTimePicker_left.Location = new System.Drawing.Point(50, 36);
            this.dateTimePicker_left.Name = "dateTimePicker_left";
            this.dateTimePicker_left.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker_left.TabIndex = 0;
            this.dateTimePicker_left.Value = new System.DateTime(2023, 5, 10, 11, 27, 0, 0);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Products.ResumeLayout(false);
            this.tabPage_Products.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel_products.ResumeLayout(false);
            this.tableLayoutPanel_products.PerformLayout();
            this.tabPage_Materials.ResumeLayout(false);
            this.tabPage_Materials.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel_use_materials.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabPage_Analysis.ResumeLayout(false);
            this.tabPage_Analysis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_extrapolation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Products;
        private System.Windows.Forms.TabPage tabPage_Materials;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_products;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage_Analysis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker_left;
        private System.Windows.Forms.DateTimePicker dateTimePicker_right;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_use_materials;
        private System.Windows.Forms.Button button_add_use_maaterials;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TreeView treeView_warehouse_materials;
        private System.Windows.Forms.ListView listView_admission;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listView_write_off;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_sort;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_extrapolation;
        private System.Windows.Forms.Button button_new_material;
        private System.Windows.Forms.RichTextBox richTextBox_description;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

