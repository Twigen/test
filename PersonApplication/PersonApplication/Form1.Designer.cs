namespace PersonApplication
{
    partial class Form1
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
            this.telephone = new System.Windows.Forms.TextBox();
            this.telAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // telephone
            // 
            this.telephone.Location = new System.Drawing.Point(57, 62);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(100, 20);
            this.telephone.TabIndex = 0;
            // 
            // telAdd
            // 
            this.telAdd.Location = new System.Drawing.Point(57, 88);
            this.telAdd.Name = "telAdd";
            this.telAdd.Size = new System.Drawing.Size(75, 23);
            this.telAdd.TabIndex = 1;
            this.telAdd.Text = "Add";
            this.telAdd.UseVisualStyleBackColor = true;
            this.telAdd.Click += new System.EventHandler(this.telAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.telAdd);
            this.Controls.Add(this.telephone);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.Button telAdd;
    }
}

