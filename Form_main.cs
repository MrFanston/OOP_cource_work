using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace OOP_Course_work
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Список всех товаров на складе
        List<Product> products = new List<Product>();

        // Список всех материалов на складе
        List<Materials.Material> materials = new List<Materials.Material>();

        // Список используемых материалов
        List<Materials.Material> use_materials = new List<Materials.Material>();

        // Список поступлений и списаний
        List<Accounting.Operation> operations = new List<Accounting.Operation>();

        public List<Materials.Material> get_materials()
        {
            return materials;
        }

        public void set_materials(List<Materials.Material> materials)
        {
            this.materials = materials;
        }

        public List<Product> get_products()
        {
            return products;
        }

        public void set_products(List<Product> products)
        {
            this.products = products;
        }

        public List<Materials.Material> get_use_materials()
        {
            return use_materials;
        }

        public void set_use_materials(List<Materials.Material> materials)
        {
            this.use_materials = materials;
        }

        public List<Accounting.Operation> get_operations()
        {
            return operations;
        }

        public void set_operatins(List<Accounting.Operation> operations)
        {
            this.operations = operations;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Считываем данные с таблицы
            string dataDir = "C:\\Users\\Владимир\\Documents\\КГУ\\4 семестр\\ООП\\OOP_Course_work\\book.xlsx";

            Aspose aspose = new Aspose(dataDir);

            products = aspose.warehouse_products(products);

            materials = aspose.warehouse_materials(materials);

            use_materials = aspose.use_materials(use_materials);

            operations = aspose.operations(operations);

            foreach (Materials.Material obj in materials)
            {
                TreeNode node = new TreeNode(obj.get_name());

                // Связывание объекта с узлом через свойство Tag
                node.Tag = obj;

                add_treeNode(node, obj);
            }
        }

        public void add_treeNode(TreeNode node, Materials.Material obj)
        {
            if (obj.GetType() == typeof(Materials.Laser))
            {
                treeView_warehouse_materials.Nodes[0].Nodes[0].Nodes.Add(node);
            }
            else if (obj.GetType() == typeof(Materials.PrinterFDM))
            {
                treeView_warehouse_materials.Nodes[0].Nodes[1].Nodes[0].Nodes.Add(node);
            }
            else if (obj.GetType() == typeof(Materials.PrinterSLA))
            {
                treeView_warehouse_materials.Nodes[0].Nodes[1].Nodes[1].Nodes.Add(node);
            }
            else if (obj.GetType() == typeof(Materials.Unprocessed))
            {
                treeView_warehouse_materials.Nodes[1].Nodes.Add(node);
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
                    Materials.Material material = (Materials.Material)treeView_warehouse_materials.SelectedNode.Tag;

                    add_row_material(tableLayoutPanel_use_materials, material);

                    treeView_warehouse_materials.Nodes.Remove(treeView_warehouse_materials.SelectedNode);

                    materials.Remove(material);

                    use_materials.Add(material);
                }
                else if(tableLayoutPanel.Name == "tableLayoutPanel_products")
                {
                    // Открываем форму внесения нового товара
                    var form_new_product = new Form_new_product(this);
                    var result = form_new_product.ShowDialog();
                    if(result == DialogResult.OK)
                    {
                        add_row(tableLayoutPanel, products[products.Count - 1]);
                    }
                }
            }
            else
            {
                TableLayoutPanelCellPosition position = tableLayoutPanel.GetPositionFromControl(button);
                // Удаляем строку
                RemoveRowFromTableLayoutPanel(tableLayoutPanel, position.Row);

            }
        }

        private void add_row(TableLayoutPanel tableLayoutPanel, Product product)
        {
            // Создание кнопки удаления
            var new_button_del = new System.Windows.Forms.Button();

            // Создание тектового поля
            var new_lable = new System.Windows.Forms.Label();

            // Создание кнопки дополнительной информации
            var new_button_extra = new System.Windows.Forms.Button();

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

            // Добавляем элементы в строку
            tableLayoutPanel.RowCount = ++tableLayoutPanel.RowCount;

            tableLayoutPanel.Controls.Add(new_button_del, 0, tableLayoutPanel.RowCount - 1);
            tableLayoutPanel.Controls.Add(new_lable, 1, tableLayoutPanel.RowCount - 1);
            tableLayoutPanel.Controls.Add(new_button_extra, 2, tableLayoutPanel.RowCount - 1);
        }

        private void add_row_material(TableLayoutPanel tableLayoutPanel, Materials.Material material)
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

        private void RemoveRowFromTableLayoutPanel(TableLayoutPanel tableLayoutPanel, int rowIndex)
        { 
            var control = tableLayoutPanel.GetControlFromPosition(1, rowIndex);
            Materials.Material material = (Materials.Material)control.Tag;
            
            // Удаляем объект из списка
            use_materials.Remove(material);

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
            var form_new_material = new Form_new_material(this);
            form_new_material.ShowDialog();
        }

        private void treeView_warehouse_materials_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Проверяем, что выбранный узел является листом
            if (e.Node.Nodes.Count == 0)
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
    }
}
