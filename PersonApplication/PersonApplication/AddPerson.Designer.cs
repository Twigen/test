namespace PersonApplication
{
    partial class AddPerson
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
            this.telephoneTb = new System.Windows.Forms.TextBox();
            this.telAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.addressTb = new System.Windows.Forms.TextBox();
            this.surnameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // telephoneTb
            // 
            this.telephoneTb.Location = new System.Drawing.Point(212, 74);
            this.telephoneTb.Name = "telephoneTb";
            this.telephoneTb.Size = new System.Drawing.Size(100, 20);
            this.telephoneTb.TabIndex = 0;
            // 
            // telAdd
            // 
            this.telAdd.Location = new System.Drawing.Point(109, 208);
            this.telAdd.Name = "telAdd";
            this.telAdd.Size = new System.Drawing.Size(119, 23);
            this.telAdd.TabIndex = 1;
            this.telAdd.Text = "Add";
            this.telAdd.UseVisualStyleBackColor = true;
            this.telAdd.Click += new System.EventHandler(this.telAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add telephone number";
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(32, 74);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(100, 20);
            this.nameTb.TabIndex = 3;
            // 
            // addressTb
            // 
            this.addressTb.Location = new System.Drawing.Point(212, 143);
            this.addressTb.Name = "addressTb";
            this.addressTb.Size = new System.Drawing.Size(100, 20);
            this.addressTb.TabIndex = 4;
            // 
            // surnameTb
            // 
            this.surnameTb.Location = new System.Drawing.Point(32, 143);
            this.surnameTb.Name = "surnameTb";
            this.surnameTb.Size = new System.Drawing.Size(100, 20);
            this.surnameTb.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Add name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Add address";
            // 
            // AddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 320);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.surnameTb);
            this.Controls.Add(this.addressTb);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.telAdd);
            this.Controls.Add(this.telephoneTb);
            this.Name = "AddPerson";
            this.Text = "Add person";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox telephoneTb;
        private System.Windows.Forms.Button telAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.TextBox addressTb;
        private System.Windows.Forms.TextBox surnameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

