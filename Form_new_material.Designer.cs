namespace OOP_Course_work
{
    partial class Form_new_material
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
            this.radioButton_processable = new System.Windows.Forms.RadioButton();
            this.radioButton_no_processable = new System.Windows.Forms.RadioButton();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.groupBox_name = new System.Windows.Forms.GroupBox();
            this.groupBox_price = new System.Windows.Forms.GroupBox();
            this.numericUpDown_price = new System.Windows.Forms.NumericUpDown();
            this.groupBox_feature = new System.Windows.Forms.GroupBox();
            this.groupBox_measure = new System.Windows.Forms.GroupBox();
            this.numericUpDown_measure = new System.Windows.Forms.NumericUpDown();
            this.groupBox_count = new System.Windows.Forms.GroupBox();
            this.numericUpDown_count = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_feature = new System.Windows.Forms.NumericUpDown();
            this.checkBox_feature = new System.Windows.Forms.CheckBox();
            this.groupBox_name.SuspendLayout();
            this.groupBox_price.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_price)).BeginInit();
            this.groupBox_feature.SuspendLayout();
            this.groupBox_measure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_measure)).BeginInit();
            this.groupBox_count.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_feature)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton_processable
            // 
            this.radioButton_processable.AutoSize = true;
            this.radioButton_processable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_processable.Location = new System.Drawing.Point(13, 20);
            this.radioButton_processable.Name = "radioButton_processable";
            this.radioButton_processable.Size = new System.Drawing.Size(144, 21);
            this.radioButton_processable.TabIndex = 8;
            this.radioButton_processable.TabStop = true;
            this.radioButton_processable.Text = "Обрабатываемый";
            this.radioButton_processable.UseVisualStyleBackColor = true;
            this.radioButton_processable.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton_no_processable
            // 
            this.radioButton_no_processable.AutoSize = true;
            this.radioButton_no_processable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_no_processable.Location = new System.Drawing.Point(163, 20);
            this.radioButton_no_processable.Name = "radioButton_no_processable";
            this.radioButton_no_processable.Size = new System.Drawing.Size(161, 21);
            this.radioButton_no_processable.TabIndex = 1;
            this.radioButton_no_processable.TabStop = true;
            this.radioButton_no_processable.Text = "Необрабытываемый";
            this.radioButton_no_processable.UseVisualStyleBackColor = true;
            this.radioButton_no_processable.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // comboBox_type
            // 
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "Лазер",
            "Принтер FDM",
            "Принтер SLA"});
            this.comboBox_type.Location = new System.Drawing.Point(13, 60);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(153, 21);
            this.comboBox_type.TabIndex = 2;
            this.comboBox_type.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button_add
            // 
            this.button_add.Enabled = false;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(19, 351);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(82, 30);
            this.button_add.TabIndex = 5;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel.Location = new System.Drawing.Point(301, 351);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(74, 30);
            this.button_cancel.TabIndex = 0;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_name.Location = new System.Drawing.Point(6, 22);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(343, 23);
            this.textBox_name.TabIndex = 10;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox_name
            // 
            this.groupBox_name.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox_name.Controls.Add(this.textBox_name);
            this.groupBox_name.Enabled = false;
            this.groupBox_name.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_name.Location = new System.Drawing.Point(13, 106);
            this.groupBox_name.Name = "groupBox_name";
            this.groupBox_name.Size = new System.Drawing.Size(355, 52);
            this.groupBox_name.TabIndex = 11;
            this.groupBox_name.TabStop = false;
            this.groupBox_name.Text = "Название";
            // 
            // groupBox_price
            // 
            this.groupBox_price.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox_price.Controls.Add(this.numericUpDown_price);
            this.groupBox_price.Enabled = false;
            this.groupBox_price.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_price.Location = new System.Drawing.Point(14, 164);
            this.groupBox_price.Name = "groupBox_price";
            this.groupBox_price.Size = new System.Drawing.Size(175, 52);
            this.groupBox_price.TabIndex = 12;
            this.groupBox_price.TabStop = false;
            this.groupBox_price.Text = "Цена";
            // 
            // numericUpDown_price
            // 
            this.numericUpDown_price.DecimalPlaces = 2;
            this.numericUpDown_price.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_price.Location = new System.Drawing.Point(6, 22);
            this.numericUpDown_price.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_price.Name = "numericUpDown_price";
            this.numericUpDown_price.Size = new System.Drawing.Size(159, 23);
            this.numericUpDown_price.TabIndex = 0;
            this.numericUpDown_price.ThousandsSeparator = true;
            // 
            // groupBox_feature
            // 
            this.groupBox_feature.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox_feature.Controls.Add(this.numericUpDown_feature);
            this.groupBox_feature.Enabled = false;
            this.groupBox_feature.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox_feature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_feature.Location = new System.Drawing.Point(13, 280);
            this.groupBox_feature.Name = "groupBox_feature";
            this.groupBox_feature.Size = new System.Drawing.Size(175, 52);
            this.groupBox_feature.TabIndex = 13;
            this.groupBox_feature.TabStop = false;
            this.groupBox_feature.Text = "Ширина";
            // 
            // groupBox_measure
            // 
            this.groupBox_measure.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox_measure.Controls.Add(this.numericUpDown_measure);
            this.groupBox_measure.Enabled = false;
            this.groupBox_measure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox_measure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_measure.Location = new System.Drawing.Point(14, 222);
            this.groupBox_measure.Name = "groupBox_measure";
            this.groupBox_measure.Size = new System.Drawing.Size(175, 52);
            this.groupBox_measure.TabIndex = 14;
            this.groupBox_measure.TabStop = false;
            this.groupBox_measure.Text = "Обьем (мл)";
            // 
            // numericUpDown_measure
            // 
            this.numericUpDown_measure.DecimalPlaces = 2;
            this.numericUpDown_measure.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_measure.Location = new System.Drawing.Point(5, 22);
            this.numericUpDown_measure.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_measure.Name = "numericUpDown_measure";
            this.numericUpDown_measure.Size = new System.Drawing.Size(159, 23);
            this.numericUpDown_measure.TabIndex = 1;
            this.numericUpDown_measure.ThousandsSeparator = true;
            // 
            // groupBox_count
            // 
            this.groupBox_count.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox_count.Controls.Add(this.numericUpDown_count);
            this.groupBox_count.Enabled = false;
            this.groupBox_count.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_count.Location = new System.Drawing.Point(195, 164);
            this.groupBox_count.Name = "groupBox_count";
            this.groupBox_count.Size = new System.Drawing.Size(103, 52);
            this.groupBox_count.TabIndex = 15;
            this.groupBox_count.TabStop = false;
            this.groupBox_count.Text = "Количество";
            // 
            // numericUpDown_count
            // 
            this.numericUpDown_count.Location = new System.Drawing.Point(6, 23);
            this.numericUpDown_count.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_count.Name = "numericUpDown_count";
            this.numericUpDown_count.Size = new System.Drawing.Size(84, 23);
            this.numericUpDown_count.TabIndex = 0;
            this.numericUpDown_count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_feature
            // 
            this.numericUpDown_feature.DecimalPlaces = 2;
            this.numericUpDown_feature.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_feature.Location = new System.Drawing.Point(7, 22);
            this.numericUpDown_feature.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_feature.Name = "numericUpDown_feature";
            this.numericUpDown_feature.Size = new System.Drawing.Size(159, 23);
            this.numericUpDown_feature.TabIndex = 2;
            this.numericUpDown_feature.ThousandsSeparator = true;
            // 
            // checkBox_feature
            // 
            this.checkBox_feature.AutoSize = true;
            this.checkBox_feature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_feature.Location = new System.Drawing.Point(201, 244);
            this.checkBox_feature.Name = "checkBox_feature";
            this.checkBox_feature.Size = new System.Drawing.Size(100, 21);
            this.checkBox_feature.TabIndex = 16;
            this.checkBox_feature.Text = "Водомойка";
            this.checkBox_feature.UseVisualStyleBackColor = true;
            this.checkBox_feature.Visible = false;
            // 
            // Form_new_material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(387, 392);
            this.Controls.Add(this.checkBox_feature);
            this.Controls.Add(this.groupBox_count);
            this.Controls.Add(this.groupBox_measure);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.groupBox_name);
            this.Controls.Add(this.groupBox_feature);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.groupBox_price);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.radioButton_no_processable);
            this.Controls.Add(this.radioButton_processable);
            this.Name = "Form_new_material";
            this.Text = "Настройка нового материала";
            this.Load += new System.EventHandler(this.Form_new_material_Load);
            this.groupBox_name.ResumeLayout(false);
            this.groupBox_name.PerformLayout();
            this.groupBox_price.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_price)).EndInit();
            this.groupBox_feature.ResumeLayout(false);
            this.groupBox_measure.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_measure)).EndInit();
            this.groupBox_count.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_feature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_processable;
        private System.Windows.Forms.RadioButton radioButton_no_processable;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.GroupBox groupBox_name;
        private System.Windows.Forms.GroupBox groupBox_price;
        private System.Windows.Forms.GroupBox groupBox_feature;
        private System.Windows.Forms.GroupBox groupBox_count;
        private System.Windows.Forms.NumericUpDown numericUpDown_count;
        private System.Windows.Forms.GroupBox groupBox_measure;
        private System.Windows.Forms.NumericUpDown numericUpDown_price;
        private System.Windows.Forms.NumericUpDown numericUpDown_measure;
        private System.Windows.Forms.NumericUpDown numericUpDown_feature;
        private System.Windows.Forms.CheckBox checkBox_feature;
    }
}