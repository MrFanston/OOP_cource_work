namespace OOP_Course_work
{
    partial class Form_new_product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel_use_materials = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox_name = new System.Windows.Forms.GroupBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.groupBox_description = new System.Windows.Forms.GroupBox();
            this.richTextBox_description = new System.Windows.Forms.RichTextBox();
            this.button_add_product = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.groupBox_name.SuspendLayout();
            this.groupBox_description.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_use_materials
            // 
            this.tableLayoutPanel_use_materials.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel_use_materials.AutoSize = true;
            this.tableLayoutPanel_use_materials.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel_use_materials.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel_use_materials.ColumnCount = 4;
            this.tableLayoutPanel_use_materials.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_use_materials.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_use_materials.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_use_materials.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_use_materials.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_use_materials.Name = "tableLayoutPanel_use_materials";
            this.tableLayoutPanel_use_materials.RowCount = 1;
            this.tableLayoutPanel_use_materials.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_use_materials.Size = new System.Drawing.Size(598, 35);
            this.tableLayoutPanel_use_materials.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.Tan;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tableLayoutPanel_use_materials);
            this.panel3.Location = new System.Drawing.Point(12, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(634, 278);
            this.panel3.TabIndex = 4;
            // 
            // groupBox_name
            // 
            this.groupBox_name.Controls.Add(this.textBox_name);
            this.groupBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_name.Location = new System.Drawing.Point(12, 12);
            this.groupBox_name.Name = "groupBox_name";
            this.groupBox_name.Size = new System.Drawing.Size(634, 51);
            this.groupBox_name.TabIndex = 5;
            this.groupBox_name.TabStop = false;
            this.groupBox_name.Text = "Название";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(6, 22);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(622, 26);
            this.textBox_name.TabIndex = 0;
            // 
            // groupBox_description
            // 
            this.groupBox_description.Controls.Add(this.richTextBox_description);
            this.groupBox_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_description.Location = new System.Drawing.Point(12, 378);
            this.groupBox_description.Name = "groupBox_description";
            this.groupBox_description.Size = new System.Drawing.Size(634, 213);
            this.groupBox_description.TabIndex = 6;
            this.groupBox_description.TabStop = false;
            this.groupBox_description.Text = "Описание";
            // 
            // richTextBox_description
            // 
            this.richTextBox_description.Location = new System.Drawing.Point(6, 25);
            this.richTextBox_description.Name = "richTextBox_description";
            this.richTextBox_description.Size = new System.Drawing.Size(622, 182);
            this.richTextBox_description.TabIndex = 0;
            this.richTextBox_description.Text = "";
            // 
            // button_add_product
            // 
            this.button_add_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add_product.Location = new System.Drawing.Point(12, 597);
            this.button_add_product.Name = "button_add_product";
            this.button_add_product.Size = new System.Drawing.Size(87, 28);
            this.button_add_product.TabIndex = 7;
            this.button_add_product.Text = "Добавить";
            this.button_add_product.UseVisualStyleBackColor = true;
            this.button_add_product.Click += new System.EventHandler(this.button_add_product_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel.Location = new System.Drawing.Point(559, 597);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(87, 28);
            this.button_cancel.TabIndex = 8;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Используемые материалы";
            // 
            // Form_new_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(658, 632);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_add_product);
            this.Controls.Add(this.groupBox_description);
            this.Controls.Add(this.groupBox_name);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form_new_product";
            this.Text = "Новый товар";
            this.Load += new System.EventHandler(this.Form_new_product_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox_name.ResumeLayout(false);
            this.groupBox_name.PerformLayout();
            this.groupBox_description.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_use_materials;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.GroupBox groupBox_description;
        private System.Windows.Forms.RichTextBox richTextBox_description;
        private System.Windows.Forms.Button button_add_product;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label1;
    }
}