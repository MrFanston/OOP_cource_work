using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOP_Course_work
{
    public partial class Form_new_product : Form
    {
        MainViewModel mainViewModel;
        List<Material> use_materials;

        public Form_new_product(MainViewModel mainViewModel)
        {
            InitializeComponent();
            this.mainViewModel = mainViewModel;
            use_materials = mainViewModel.get_use_materials();
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
            string name_product = textBox_name.Text;
            string descripions = richTextBox_description.Text;
            List<Material> product_materials = new List<Material>();

            for(int i = 0; i < use_materials.Count; i++)
            {
                CheckBox checkBox = (CheckBox)tableLayoutPanel_use_materials.Controls[i * 4];
                if (checkBox.Checked)
                {
                    // Используемый материал для создания товара
                    Material material = (Material)checkBox.Tag;

                    // Копия материала, но в свойстве текущего значения задано используемое количество для товара
                    Material component;

                    string name_material = material.get_name();
                    float price = material.get_price();
                    float value_max = material.get_value_max();
                    float value_current = (float)((NumericUpDown)tableLayoutPanel_use_materials.Controls[3 + i * 4]).Value;
                    material.set_value_current(material.get_value_current() - value_current);

                    if (material.GetType() == typeof(Unprocessed))
                    {
                        component = new Unprocessed(name_material, price);
                    }
                    else if (material.GetType() == typeof(Laser))
                    {
                        float thickness = ((Laser)material).get_thickness();
                        component = new Laser(name_material, price, thickness, value_max, value_current);
                    }
                    else if (material.GetType() == typeof(PrinterFDM))
                    {
                        string heat_resistant = ((PrinterFDM)material).get_heat_resistant();
                        component = new PrinterFDM(name_material, price, heat_resistant, value_max, value_current);
                    }
                    // (material.GetType() == typeof(Materials.PrinterSLA))
                    else
                    {
                        string water_washer = ((PrinterSLA)material).get_water_washer();
                        component = new PrinterSLA(name_material, price, water_washer, value_max, value_current);
                    }

                    product_materials.Add(component);
                }
            }
            
            Product product = new Product(name_product, descripions, product_materials);

            mainViewModel.add_product(product);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
