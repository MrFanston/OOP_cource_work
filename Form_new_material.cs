using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OOP_Course_work.Materials;

namespace OOP_Course_work
{
    public partial class Form_new_material : Form
    {
        MainForm mainForm;

        public Form_new_material(MainForm Form_main)
        {
            InitializeComponent();
            mainForm = Form_main;
        }

        private void Form_new_material_Load(object sender, EventArgs e)
        {
            comboBox_type.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_type.Enabled = false;
            groupBox_color.Visible = false;
            groupBox_measure.Visible = false;
            groupBox_thickness.Visible = false;
            groupBox_name.Enabled = true;
            groupBox_price.Enabled = true;
            groupBox_count.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_type.Enabled = true;
            groupBox_color.Visible = true;
            groupBox_measure.Visible = true;
            comboBox_type.SelectedIndex = 0;
            groupBox_thickness.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox_name.Text.Length > 0)
            {
                button_add.Enabled = true;
            }
            else
            {
                button_add.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecteVal = comboBox_type.SelectedItem.ToString();
            if (selecteVal == "Лазер")
            {
                groupBox_measure.Text = "Площадь листа";
                groupBox_thickness.Visible = true;
            }
            else if (selecteVal == "Принтер FDM")
            {
                groupBox_measure.Text = "Масса(г)";
                groupBox_thickness.Visible = false;
            }
            else if (selecteVal == "Принтер SLA")
            {
                groupBox_measure.Text = "Обьем(мл)";
                groupBox_thickness.Visible = false;
            }

            groupBox_name.Enabled = true;
            groupBox_price.Enabled = true;
            groupBox_color.Enabled = true;
            groupBox_measure.Enabled = true;
            groupBox_count.Enabled = true;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if(radioButton_processable.Checked)
            {
                if(comboBox_type.Text == "Лазер")
                {
                    List<Materials.Material> materials = mainForm.get_materials();

                    string name = textBox_name.Text;
                    float price = (float)numericUpDown_price.Value;
                    string color = textBox_color.Text;
                    float measure = (float)numericUpDown_measure.Value;
                    float thickness = (float)numericUpDown_thickness.Value;

                    int count = (int)numericUpDown_count.Value;

                    for(int i = 0; i < count; i++)
                    {
                        Materials.Laser laser = new Materials.Laser(name, price, color, thickness, measure, measure);
                        materials.Add(laser);

                        TreeNode node = new TreeNode(name);

                        // Связывание объекта с узлом через свойство Tag
                        node.Tag = laser;

                        mainForm.add_treeNode(node, laser);
                    }
                    
                    mainForm.set_materials(materials);
                }
                else if(comboBox_type.Text == "Принтер FDM")
                {
                    List<Materials.Material> materials = mainForm.get_materials();

                    string name = textBox_name.Text;
                    float price = (float)numericUpDown_price.Value;
                    string color = textBox_color.Text;
                    float measure = (float)numericUpDown_measure.Value;

                    int count = (int)numericUpDown_count.Value;

                    for (int i = 0; i < count; i++)
                    {
                        Materials.PrinterFDM fdm = new Materials.PrinterFDM(name, price, color, measure, measure);
                        materials.Add(fdm);

                        TreeNode node = new TreeNode(name);

                        // Связывание объекта с узлом через свойство Tag
                        node.Tag = fdm;

                        mainForm.add_treeNode(node, fdm);
                    }
                    
                    mainForm.set_materials(materials);
                }
                else if (comboBox_type.Text == "Принтер SLA")
                {
                    List<Materials.Material> materials = mainForm.get_materials();

                    string name = textBox_name.Text;
                    float price = (float)numericUpDown_price.Value;
                    string color = textBox_color.Text;
                    float measure = (float)numericUpDown_measure.Value;

                    int count = (int)numericUpDown_count.Value;

                    for (int i = 0; i < count; i++)
                    {
                        Materials.PrinterSLA sla = new Materials.PrinterSLA(name, price, color, measure, measure);
                        materials.Add(sla);

                        TreeNode node = new TreeNode(name);

                        // Связывание объекта с узлом через свойство Tag
                        node.Tag = sla;

                        mainForm.add_treeNode(node, sla);
                    }

                    mainForm.set_materials(materials);
                }

            }
            else
            {
                List<Materials.Material> materials = mainForm.get_materials();

                string name = textBox_name.Text;
                float price = (float)numericUpDown_price.Value;

                int count = (int)numericUpDown_count.Value;

                for (int i = 0; i < count; i++)
                {
                    Materials.Unprocessed unprocessed = new Materials.Unprocessed(name, price);
                    materials.Add(unprocessed);

                    TreeNode node = new TreeNode(name);

                    // Связывание объекта с узлом через свойство Tag
                    node.Tag = unprocessed;

                    mainForm.add_treeNode(node, unprocessed);
                }

                mainForm.set_materials(materials);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
