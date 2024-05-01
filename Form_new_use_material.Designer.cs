namespace OOP_Course_work
{
    partial class Form_new_use_material
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
            this.treeView_materials = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView_materials
            // 
            this.treeView_materials.Location = new System.Drawing.Point(27, 27);
            this.treeView_materials.Name = "treeView_materials";
            this.treeView_materials.Size = new System.Drawing.Size(221, 165);
            this.treeView_materials.TabIndex = 0;
            // 
            // Form_new_use_material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView_materials);
            this.Name = "Form_new_use_material";
            this.Text = "Перенос со склада материала";
            this.Load += new System.EventHandler(this.Form_new_use_material_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView_materials;
    }
}