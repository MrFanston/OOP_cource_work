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

namespace OOP_Course_work
{
    public partial class Form_new_material : Form
    {
        public Form_new_material()
        {
            InitializeComponent();
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
            groupBox_name.Enabled = true;
            groupBox_price.Enabled = true;
            groupBox_count.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_type.Enabled = true;
            groupBox_color.Visible = true;
            groupBox_measure.Visible = true;
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
            }
            else if (selecteVal == "Принтер FDM")
            {
                groupBox_measure.Text = "Масса(кг)";
            }
            else if (selecteVal == "Принтер SLA")
            {
                groupBox_measure.Text = "Обьем(мл)";
            }

            groupBox_name.Enabled = true;
            groupBox_price.Enabled = true;
            groupBox_color.Enabled = true;
            groupBox_measure.Enabled = true;
            groupBox_count.Enabled = true;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if(radioButton_no_processable.Checked)
            {

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
