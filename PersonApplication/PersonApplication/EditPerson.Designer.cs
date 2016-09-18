namespace PersonApplication
{
    partial class EditPerson
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
            this.nameTbEp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.surnameTbEp = new System.Windows.Forms.TextBox();
            this.addressTbEp = new System.Windows.Forms.TextBox();
            this.telNumberEp = new System.Windows.Forms.TextBox();
            this.editBtnEditPerson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTbEp
            // 
            this.nameTbEp.Location = new System.Drawing.Point(29, 55);
            this.nameTbEp.Name = "nameTbEp";
            this.nameTbEp.Size = new System.Drawing.Size(143, 20);
            this.nameTbEp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telephone number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address";
            // 
            // surnameTbEp
            // 
            this.surnameTbEp.Location = new System.Drawing.Point(29, 118);
            this.surnameTbEp.Name = "surnameTbEp";
            this.surnameTbEp.Size = new System.Drawing.Size(143, 20);
            this.surnameTbEp.TabIndex = 5;
            // 
            // addressTbEp
            // 
            this.addressTbEp.Location = new System.Drawing.Point(219, 118);
            this.addressTbEp.Name = "addressTbEp";
            this.addressTbEp.Size = new System.Drawing.Size(140, 20);
            this.addressTbEp.TabIndex = 6;
            // 
            // telNumberEp
            // 
            this.telNumberEp.Location = new System.Drawing.Point(219, 55);
            this.telNumberEp.Name = "telNumberEp";
            this.telNumberEp.Size = new System.Drawing.Size(140, 20);
            this.telNumberEp.TabIndex = 7;
            // 
            // editBtnEditPerson
            // 
            this.editBtnEditPerson.Location = new System.Drawing.Point(129, 182);
            this.editBtnEditPerson.Name = "editBtnEditPerson";
            this.editBtnEditPerson.Size = new System.Drawing.Size(135, 23);
            this.editBtnEditPerson.TabIndex = 8;
            this.editBtnEditPerson.Text = "Edit";
            this.editBtnEditPerson.UseVisualStyleBackColor = true;
            // 
            // EditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 283);
            this.Controls.Add(this.editBtnEditPerson);
            this.Controls.Add(this.telNumberEp);
            this.Controls.Add(this.addressTbEp);
            this.Controls.Add(this.surnameTbEp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTbEp);
            this.Name = "EditPerson";
            this.Text = "EditPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTbEp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox surnameTbEp;
        private System.Windows.Forms.TextBox addressTbEp;
        private System.Windows.Forms.TextBox telNumberEp;
        private System.Windows.Forms.Button editBtnEditPerson;
    }
}