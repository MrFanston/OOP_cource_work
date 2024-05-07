using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Course_work
{
    public partial class Form_new_product : Form
    {
        MainForm main_form;
        List<Materials.Material> use_materials;

        public Form_new_product(MainForm Form_main)
        {
            InitializeComponent();
            main_form = Form_main;
            use_materials = main_form.get_use_materials();
        }

        private void Form_new_product_Load(object sender, EventArgs e)
        {
            // Заполняем таблицу используемых материалов
            for (int i = 0; i < use_materials.Count; i++)
            {
                var new_checkBox = new CheckBox();

                var new_label_name = new Label();

                var new_label_measure = new Label();

                var new_numericUpDown_use_measure = new NumericUpDown();
                // 
                // new_checkBox
                // 
                new_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
                new_checkBox.AutoSize = true;
                new_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                new_checkBox.Location = new System.Drawing.Point(5, 10);
                new_checkBox.Name = "checkBox";
                new_checkBox.Size = new System.Drawing.Size(15, 14);
                new_checkBox.TabIndex = 6;
                new_checkBox.UseVisualStyleBackColor = true;
                // 
                // new_label_name
                // 
                new_label_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
                new_label_name.AutoSize = true;
                new_label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                new_label_name.Location = new System.Drawing.Point(28, 9);
                new_label_name.Name = "label_name";
                new_label_name.Size = new System.Drawing.Size(72, 17);
                new_label_name.TabIndex = 2;
                new_label_name.Text = use_materials[i].get_name();
                // 
                // new_label_measure
                // 
                new_label_measure.Anchor = System.Windows.Forms.AnchorStyles.Left;
                new_label_measure.AutoSize = true;
                new_label_measure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                new_label_measure.Location = new System.Drawing.Point(250, 9);
                new_label_measure.Name = "label_measure";
                new_label_measure.Size = new System.Drawing.Size(86, 17);
                new_label_measure.TabIndex = 3;
                string measure = use_materials[i].get_value_current() + " / " + use_materials[i].get_value_max();
                new_label_measure.Text = measure;
                // 
                // numericUpDown_use_measure
                // 
                new_numericUpDown_use_measure.Anchor = System.Windows.Forms.AnchorStyles.Right;
                new_numericUpDown_use_measure.DecimalPlaces = 2;
                new_numericUpDown_use_measure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                new_numericUpDown_use_measure.Increment = new decimal(new int[] {
1,
0,
0,
131072});
                new_numericUpDown_use_measure.Location = new System.Drawing.Point(473, 6);
                new_numericUpDown_use_measure.Name = "numericUpDown_use_measure";
                new_numericUpDown_use_measure.Size = new System.Drawing.Size(120, 23);
                new_numericUpDown_use_measure.TabIndex = 4;
                new_numericUpDown_use_measure.ThousandsSeparator = true;
                new_numericUpDown_use_measure.Maximum = (decimal)use_materials[i].get_value_current();


                // Добавляем элементы в строку
                tableLayoutPanel_use_materials.RowCount = ++tableLayoutPanel_use_materials.RowCount;

                tableLayoutPanel_use_materials.Controls.Add(new_checkBox, 0, i);
                tableLayoutPanel_use_materials.Controls.Add(new_label_name, 1, i);
                tableLayoutPanel_use_materials.Controls.Add(new_label_measure, 2, i);
                tableLayoutPanel_use_materials.Controls.Add(new_numericUpDown_use_measure, 3, i);

                // Закремляем за checkBox Tag материала
                new_checkBox.Tag = use_materials[i];
            }
        }

        private void button_add_product_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;
            string descripions = richTextBox_description.Text;
            List<Materials.Material> product_materials = new List<Materials.Material>();

            for(int i = 0; i < use_materials.Count; i++)
            {
                CheckBox checkBox = (CheckBox)tableLayoutPanel_use_materials.Controls[i * 4];
                if (checkBox.Checked)
                {
                    product_materials.Add((Materials.Material)checkBox.Tag);
                }
            }
            
            Product product = new Product(name, descripions, product_materials);

            List<Product> products = main_form.get_products();
            products.Add(product);

            main_form.set_products(products);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
