using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOP_Course_work
{
    public partial class Form_new_material : Form
    {
        MainViewModel mainViewModel;

        public Form_new_material(MainViewModel mainViewModel)
        {
            InitializeComponent();
            this.mainViewModel = mainViewModel;
        }

        private void Form_new_material_Load(object sender, EventArgs e)
        {
            comboBox_type.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void radioButton_no_processable_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_type.Enabled = false;
            groupBox_feature.Visible = false;
            groupBox_measure.Visible = false;
            groupBox_feature.Visible = false;
            checkBox_feature.Visible = false;
            groupBox_name.Enabled = true;
            groupBox_price.Enabled = true;
        }

        private void radioButton_processable_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_type.Enabled = true;
            groupBox_measure.Visible = true;
            comboBox_type.SelectedIndex = 0;
            groupBox_feature.Visible = true;
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
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

        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecteVal = comboBox_type.SelectedItem.ToString();
            if (selecteVal == "Лазер")
            {
                groupBox_measure.Text = "Площадь листа";
                groupBox_feature.Text = "Ширина";
                groupBox_feature.Visible = true;
                groupBox_feature.Enabled = true;
                checkBox_feature.Visible = false;
            }
            else if (selecteVal == "Принтер FDM")
            {
                groupBox_measure.Text = "Масса(г)";
                groupBox_feature.Visible = false;
                checkBox_feature.Visible = true;
                checkBox_feature.Text = "Термостойкий";
            }
            else if (selecteVal == "Принтер SLA")
            {
                groupBox_measure.Text = "Обьем(мл)";
                groupBox_feature.Visible = false;
                checkBox_feature.Visible = true;
                checkBox_feature.Text = "Водомойка";
            }

            groupBox_name.Enabled = true;
            groupBox_price.Enabled = true;
            groupBox_measure.Enabled = true;
            groupBox_count.Enabled = true;
            numericUpDown_count.Enabled = true;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if(radioButton_processable.Checked)
            {
                List<Material> materials = new List<Material>();
                if(comboBox_type.Text == "Лазер")
                {
                    string name = textBox_name.Text;
                    float price = (float)numericUpDown_price.Value;
                    float measure = (float)numericUpDown_measure.Value;
                    float thickness = (float)numericUpDown_feature.Value;

                    int count = (int)numericUpDown_count.Value;

                    for(int i = 0; i < count; i++)
                    {
                        Laser laser = new Laser(name, price, thickness, measure, measure);
                        materials.Add(laser);
                    }

                    mainViewModel.add_materials(materials);
                }
                else if(comboBox_type.Text == "Принтер FDM")
                {
                    string name = textBox_name.Text;
                    float price = (float)numericUpDown_price.Value;
                    string feature;
                    if (checkBox_feature.Checked)
                    {
                        feature = "Термостойкий";
                    }
                    else
                    {
                        feature = "";
                    }
                    float measure = (float)numericUpDown_measure.Value;

                    int count = (int)numericUpDown_count.Value;

                    for (int i = 0; i < count; i++)
                    {
                        PrinterFDM fdm = new PrinterFDM(name, price, feature, measure, measure);
                        materials.Add(fdm);
                    }

                    mainViewModel.add_materials(materials);
                }
                else if (comboBox_type.Text == "Принтер SLA")
                {
                    string name = textBox_name.Text;
                    float price = (float)numericUpDown_price.Value;
                    string feature;
                    if (checkBox_feature.Checked)
                    {
                        feature = "Водомойка";
                    }
                    else
                    {
                        feature = "";
                    }
                        float measure = (float)numericUpDown_measure.Value;

                    int count = (int)numericUpDown_count.Value;

                    for (int i = 0; i < count; i++)
                    {
                        PrinterSLA sla = new PrinterSLA(name, price, feature, measure, measure);
                        materials.Add(sla);
                    }

                    mainViewModel.add_materials(materials);
                }

            }
            else
            {
                // Unprocessed
                List<Material> materials = new List<Material>();

                string name = textBox_name.Text;
                float price = (float)numericUpDown_price.Value;

                int count = (int)numericUpDown_count.Value;

                for (int i = 0; i < count; i++)
                {
                    Unprocessed unprocessed = new Unprocessed(name, price);
                    materials.Add(unprocessed);
                }

                mainViewModel.add_materials(materials);
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
