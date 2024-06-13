using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OOP_Course_work
{
    public partial class MainForm : Form
    {
        MainViewModel mainViewModel;

        public MainForm()
        {
            InitializeComponent();
            mainViewModel = new MainViewModel(this);
            this.FormClosing += MainForm_FormClosing;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Проверка условий закрытия формы
            if (MessageBox.Show("Вы уверены, что хотите закрыть приложение?", "Подтверждение закрытия", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true; // Отменить закрытие формы
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (Material obj in mainViewModel.get_materials())
            {
                TreeNode node = new TreeNode(obj.get_name());

                // Связывание объекта с узлом через свойство Tag
                node.Tag = obj;

                add_treeNode(node, obj);
            }

            foreach (Material obj in mainViewModel.get_use_materials())
            {
                add_row_material(tableLayoutPanel_use_materials, obj);
            }

            foreach (Product obj in mainViewModel.get_products())
            {
                add_row_product(tableLayoutPanel_products, obj);
            }

            foreach (Operation operation in mainViewModel.get_operations())
            {
                add_row_operation(operation);
            }
            // Установка свойство ListView на горизонтальный скроллинг
            listView_admission.AutoResizeColumns(ColumnHeaderAutoResizeStyle.None);
            listView_write_off.AutoResizeColumns(ColumnHeaderAutoResizeStyle.None);
        }

        // Событие вызываемое при создании нового материала в диалоговом окне
        public void add_materials(Material material)
        {
            TreeNode node = new TreeNode(material.get_name());

            node.Tag = material;

            add_treeNode(node, material);
        }

        // Событие вызываемое при создании нового материала в диалоговом окне
        public void add_operation(Operation operation)
        {
            add_row_operation(operation);
        }

        private void add_treeNode(TreeNode node, Material obj)
        {
            TreeNode node_void = new TreeNode("");

            if (obj.GetType() == typeof(Laser))
            {
                int count = treeView_warehouse_materials.Nodes[0].Nodes[0].Nodes.Count;
                treeView_warehouse_materials.Nodes[0].Nodes[0].Nodes[count - 1].Remove();
                
                treeView_warehouse_materials.Nodes[0].Nodes[0].Nodes.Add(node);
                treeView_warehouse_materials.Nodes[0].Nodes[0].Nodes.Add(node_void);
            }
            else if (obj.GetType() == typeof(PrinterFDM))
            {
                int count = treeView_warehouse_materials.Nodes[0].Nodes[1].Nodes[0].Nodes.Count;
                treeView_warehouse_materials.Nodes[0].Nodes[1].Nodes[0].Nodes[count - 1].Remove();

                treeView_warehouse_materials.Nodes[0].Nodes[1].Nodes[0].Nodes.Add(node);
                treeView_warehouse_materials.Nodes[0].Nodes[1].Nodes[0].Nodes.Add(node_void);
            }
            else if (obj.GetType() == typeof(PrinterSLA))
            {
                int count = treeView_warehouse_materials.Nodes[0].Nodes[1].Nodes[1].Nodes.Count;
                treeView_warehouse_materials.Nodes[0].Nodes[1].Nodes[1].Nodes[count - 1].Remove();

                treeView_warehouse_materials.Nodes[0].Nodes[1].Nodes[1].Nodes.Add(node);
                treeView_warehouse_materials.Nodes[0].Nodes[1].Nodes[1].Nodes.Add(node_void);
            }
            else if (obj.GetType() == typeof(Unprocessed))
            {
                int count = treeView_warehouse_materials.Nodes[1].Nodes.Count;
                treeView_warehouse_materials.Nodes[1].Nodes[count - 1].Remove();

                treeView_warehouse_materials.Nodes[1].Nodes.Add(node);
                treeView_warehouse_materials.Nodes[1].Nodes.Add(node_void);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {             
            // Получаем кнопку, которая вызвала событие
            var button = sender as System.Windows.Forms.Button;

            // Получаем панель в которой находится кнопка
            Control parent = button.Parent;
            var tableLayoutPanel = parent as System.Windows.Forms.TableLayoutPanel;

            if(button.Text == "+")
            {
                if (tableLayoutPanel.Name == "tableLayoutPanel_use_materials")
                {
                    Material material = (Material)treeView_warehouse_materials.SelectedNode.Tag;

                    add_row_material(tableLayoutPanel_use_materials, material);

                    treeView_warehouse_materials.Nodes.Remove(treeView_warehouse_materials.SelectedNode);

                    mainViewModel.remove_material(material);

                    mainViewModel.add_use_materials(material);
                }
                else if(tableLayoutPanel.Name == "tableLayoutPanel_products")
                {
                    // Открываем форму внесения нового товара
                    var form_new_product = new Form_new_product(mainViewModel);
                    var result = form_new_product.ShowDialog();
                    if(result == DialogResult.OK)
                    {
                        add_row_product(tableLayoutPanel, mainViewModel.get_products()[mainViewModel.get_products().Count - 1]);
                    }
                }
            }
            else if(tableLayoutPanel.Name == "tableLayoutPanel_products")
            {
                TableLayoutPanelCellPosition position = tableLayoutPanel.GetPositionFromControl(button);
                // Удаляем строку
                remove_row_product(tableLayoutPanel, position.Row);
            }
            else
            {
                TableLayoutPanelCellPosition position = tableLayoutPanel.GetPositionFromControl(button);
                // Удаляем строку
                remove_row_material(tableLayoutPanel, position.Row);
            }
        }

        private void add_row_product(TableLayoutPanel tableLayoutPanel, Product product)
        {
            // Создание кнопки удаления
            var new_button_del = new System.Windows.Forms.Button();

            // Создание тектового поля
            var new_lable = new System.Windows.Forms.Label();

            // Создание кнопки дополнительной информации
            var new_button_extra = new System.Windows.Forms.Button();

            // Дополнительная информация о товаре
            string extra = "";
            extra += "Название:\n" + product.get_name() + "\n\n";
            extra += "Описание:\n" + product.get_description() + "\n\n";
            extra += "Используемые материалы:\n";
            foreach(Material material in product.get_components().ToArray())
            {
                // Мера измерения
                string measure = "";

                // Особенность материала
                string feature = "";

                if (material.GetType() == typeof(PrinterSLA))
                {
                    measure = "мл";

                    PrinterSLA sla = (PrinterSLA)material;
                    feature = sla.get_water_washer();
                }
                else if (material.GetType() == typeof(Laser))
                {
                    measure = "мм^2";

                    Laser laser = (Laser)material;
                    feature = "Толщина - " + laser.get_thickness().ToString();
                }
                else if (material.GetType() == typeof(PrinterFDM))
                {
                    measure = "г";

                    PrinterFDM fdm = (PrinterFDM)material;
                    feature = fdm.get_heat_resistant();
                }

                extra += "\t" + material.get_name() + " " + material.get_value_current() + " " + measure + " " + feature +"\n"; 
            }
            extra += "\n";
            extra += "Цена:\n" + product.get_price() + "р";

            // Добавляем обработчик события Click для каждой созданной кнопки
            new_button_del.Click += button_add_Click;

            // Инициализация кнопки удаления
            new_button_del.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            new_button_del.BackColor = System.Drawing.Color.Red;
            new_button_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            new_button_del.Name = "button_del";
            new_button_del.Size = new System.Drawing.Size(37, 38);
            new_button_del.Text = "-";
            new_button_del.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            new_button_del.UseVisualStyleBackColor = false;

            // Инициализация текстового поля
            new_lable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            new_lable.AutoSize = true;
            new_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            new_lable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            new_lable.Location = new System.Drawing.Point(50, 17);
            new_lable.Name = "label1";
            new_lable.Size = new System.Drawing.Size(130, 20);
            new_lable.TabIndex = 1;
            new_lable.Text = product.get_name();
            new_lable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            new_lable.Tag = product;

            // Инициализация кнопки дополнительной информации
            new_button_extra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            new_button_extra.BackColor = System.Drawing.Color.LightGray;
            new_button_extra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            new_button_extra.Name = "button_extra";
            new_button_extra.Size = new System.Drawing.Size(37, 38);
            new_button_extra.Text = "...";
            new_button_extra.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            new_button_extra.UseVisualStyleBackColor = false;
            new_button_extra.Tag = extra;
            new_button_extra.Click += button_description_Click;

            // Добавляем элементы в строку
            tableLayoutPanel.RowCount = ++tableLayoutPanel.RowCount;

            tableLayoutPanel.Controls.Add(new_button_del, 0, tableLayoutPanel.RowCount - 1);
            tableLayoutPanel.Controls.Add(new_lable, 1, tableLayoutPanel.RowCount - 1);
            tableLayoutPanel.Controls.Add(new_button_extra, 2, tableLayoutPanel.RowCount - 1);
        }

        private void add_row_material(TableLayoutPanel tableLayoutPanel, Material material)
        {
            // Создание кнопки удаления
            var new_button_del = new System.Windows.Forms.Button();

            // Создание тектового поля
            var new_lable = new System.Windows.Forms.Label();

            // Добавляем обработчик события Click
            new_button_del.Click += button_add_Click;

            // Инициализация кнопки удаления
            new_button_del.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            new_button_del.BackColor = System.Drawing.Color.Red;
            new_button_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            new_button_del.Name = "button_del";
            new_button_del.Size = new System.Drawing.Size(37, 38);
            new_button_del.Text = "-";
            new_button_del.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            new_button_del.UseVisualStyleBackColor = false;

            // Инициализация текстового поля
            new_lable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            new_lable.AutoSize = true;
            new_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            new_lable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            new_lable.Name = "label1";
            new_lable.TabIndex = 1;
            new_lable.Text = material.get_name();
            new_lable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            new_lable.Tag = material;

            // Добавляем элементы в строку
            tableLayoutPanel.RowCount = ++tableLayoutPanel.RowCount;

            tableLayoutPanel.Controls.Add(new_button_del, 0, tableLayoutPanel.RowCount - 1);
            tableLayoutPanel.Controls.Add(new_lable, 1, tableLayoutPanel.RowCount - 1);

            tableLayoutPanel.Size = new Size(343, tableLayoutPanel.Size.Height + 46);
        }

        private void remove_row_material(TableLayoutPanel tableLayoutPanel, int rowIndex)
        { 
            var control = tableLayoutPanel.GetControlFromPosition(1, rowIndex);
            Material material = (Material)control.Tag;

            // Удаляем объект из списка
            mainViewModel.remove_use_material(material);

            // Удаляем текстовое поле из удаляемой строки
            tableLayoutPanel.Controls.Remove(control);

            // Перемещение элементов из строк ниже удаляемой строки на одну строку вверх
            for (int i = rowIndex + 1; i < tableLayoutPanel.RowCount; i++)
            {
                control = tableLayoutPanel.GetControlFromPosition(1, i);
                tableLayoutPanel.SetRow(control, i - 1);
            }

            // Удаляем элементы последней строки
            for (int colIndex = 0; colIndex < tableLayoutPanel.ColumnCount; colIndex++)
            {
                control = tableLayoutPanel.GetControlFromPosition(colIndex, tableLayoutPanel.RowCount - 1);
                if (control != null)
                {
                    tableLayoutPanel.Controls.Remove(control);
                    control.Dispose();
                }
            }

            // Уменьшаем количество строк, после того, как все элементы были перемещены
            tableLayoutPanel.RowCount--;

            // Уменьшаем размер контейнера
            tableLayoutPanel.Size = new Size(343, tableLayoutPanel.Size.Height - 46);
        }

        private void remove_row_product(TableLayoutPanel tableLayoutPanel, int rowIndex)
        {
            var control = tableLayoutPanel.GetControlFromPosition(1, rowIndex);
            Product product = (Product)control.Tag;

            // Добавляем новую операция списания
            float value = product.get_price();
            string description = product.get_description();

            Operation operation = new Operation(DateTime.Now, value, description);
            mainViewModel.add_operatin(operation);
            add_row_operation(operation);

            // Удаляем объект из списка
            mainViewModel.remove_product(product);

            // Удаляем текстовое поле из удаляемой строки
            tableLayoutPanel.Controls.Remove(control);

            // Перемещение элементов из строк ниже удаляемой строки на одну строку вверх
            for (int i = rowIndex + 1; i < tableLayoutPanel.RowCount; i++)
            {
                control = tableLayoutPanel.GetControlFromPosition(1, i);
                tableLayoutPanel.SetRow(control, i - 1);
            }

            // Удаляем элементы последней строки
            for (int colIndex = 0; colIndex < tableLayoutPanel.ColumnCount; colIndex++)
            {
                control = tableLayoutPanel.GetControlFromPosition(colIndex, tableLayoutPanel.RowCount - 1);
                if (control != null)
                {
                    tableLayoutPanel.Controls.Remove(control);
                    control.Dispose();
                }
            }

            // Уменьшаем количество строк, после того, как все элементы были перемещены
            tableLayoutPanel.RowCount--;

            // Уменьшаем размер контейнера
            tableLayoutPanel.Size = new Size(343, tableLayoutPanel.Size.Height - 46);
        }

        // Добавление нового материала в таблицу
        private void button_new_material_Click(object sender, EventArgs e)
        {
            // Открываем форму внесения нового материала
            var form_new_material = new Form_new_material(mainViewModel);
            var result = form_new_material.ShowDialog();
        }

        private void treeView_warehouse_materials_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Проверяем, что выбранный узел является листом
            if (e.Node.Nodes.Count == 0 && e.Node.Text!="")
            {
                button_add_use_maaterials.Enabled = true;
                button_add_use_maaterials.BackColor = Color.Lime;
            }
            else
            {
                button_add_use_maaterials.Enabled = false;
                button_add_use_maaterials.BackColor = Color.Gray;
            }
        }

        private void button_description_Click(object sender, EventArgs e)
        {
            // Получаем кнопку, которая вызвала событие
            var button = sender as System.Windows.Forms.Button;

            richTextBox_description.Text = (string)button.Tag;
            richTextBox_description.Visible = true;
        }

        private void add_row_operation(Operation operation)
        {

            if (operation.get_value() >= 0)
            {
                // Создаем новую строку
                string[] row = { (listView_admission.Items.Count + 1).ToString(), operation.get_value().ToString(),
                        operation.get_description() + " " + operation.get_data().ToString() };

                // Добавляем новую строку в ListView
                listView_admission.Items.Add(new ListViewItem(row));
            }
            else
            {
                // Создаем новую строку
                string[] row = { (listView_write_off.Items.Count + 1).ToString(), operation.get_value().ToString(),
                        operation.get_description() + " " + operation.get_data().ToString() };

                // Добавляем новую строку в ListView
                listView_write_off.Items.Add(new ListViewItem(row));
            }
        }

        private void button_sort_Click(object sender, EventArgs e)
        {
            listView_admission.Items.Clear();
            listView_write_off.Items.Clear();
            chart_extrapolation.Series.Clear();

            List<Operation> operations_filtr;

            // Получаем значения для фильтрации
            DateTime left = dateTimePicker_left.Value;
            DateTime right = dateTimePicker_right.Value;

            // Лист отсортированных в заданном интервале операций
            operations_filtr = mainViewModel.calculation_operations_filtr(left, right);
            
            foreach (Operation operation in operations_filtr)
            {
                add_row_operation(operation);
            }

            // Точки приращений от начальной операции до последней + экстраполяционное приращение
            List<float> increments = mainViewModel.calculation_increments(operations_filtr);

            // Рисуем график
            // Вносим приращения исходных значений
            chart_extrapolation.Series.Add("increment");
            chart_extrapolation.Series["increment"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart_extrapolation.Series["increment"].Color = Color.Blue;

            int x = 0;
            
            for (int i = 0; i < increments.Count - 1; i++)
            {
                chart_extrapolation.Series["increment"].Points.AddXY(x++, increments[i]);
            }

            // Вносим значение экстраполяции
            chart_extrapolation.Series.Add("extrapolation");
            chart_extrapolation.Series["extrapolation"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart_extrapolation.Series["extrapolation"].Color = Color.Red;

            chart_extrapolation.Series["extrapolation"].Points.AddXY(--x, increments[increments.Count - 2]);
            chart_extrapolation.Series["extrapolation"].Points.AddXY(++x, increments[increments.Count - 2] + increments.Last());

        }
    }
}
