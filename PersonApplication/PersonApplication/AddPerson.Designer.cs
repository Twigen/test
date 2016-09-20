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
            this.components = new System.ComponentModel.Container();
            this.telAdd = new System.Windows.Forms.Button();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.addressTb = new System.Windows.Forms.TextBox();
            this.surnameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteNumberButton = new System.Windows.Forms.Button();
            this.addNumberButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.newTelNumberTb = new System.Windows.Forms.TextBox();
            this.telNumberList = new System.Windows.Forms.ListBox();
            this.telNumbersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telNumbersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // telAdd
            // 
            this.telAdd.Location = new System.Drawing.Point(263, 285);
            this.telAdd.Name = "telAdd";
            this.telAdd.Size = new System.Drawing.Size(119, 23);
            this.telAdd.TabIndex = 1;
            this.telAdd.Text = "Add";
            this.telAdd.UseVisualStyleBackColor = true;
            this.telAdd.Click += new System.EventHandler(this.telAdd_Click);
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(87, 28);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(202, 20);
            this.nameTb.TabIndex = 3;
            // 
            // addressTb
            // 
            this.addressTb.Location = new System.Drawing.Point(87, 107);
            this.addressTb.Name = "addressTb";
            this.addressTb.Size = new System.Drawing.Size(202, 20);
            this.addressTb.TabIndex = 4;
            // 
            // surnameTb
            // 
            this.surnameTb.Location = new System.Drawing.Point(87, 67);
            this.surnameTb.Name = "surnameTb";
            this.surnameTb.Size = new System.Drawing.Size(202, 20);
            this.surnameTb.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Add name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Add address";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameTb);
            this.groupBox1.Controls.Add(this.addressTb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.surnameTb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 163);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Person details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deleteNumberButton);
            this.groupBox2.Controls.Add(this.addNumberButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.newTelNumberTb);
            this.groupBox2.Controls.Add(this.telNumberList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 116);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tel numbers";
            // 
            // deleteNumberButton
            // 
            this.deleteNumberButton.Location = new System.Drawing.Point(307, 26);
            this.deleteNumberButton.Name = "deleteNumberButton";
            this.deleteNumberButton.Size = new System.Drawing.Size(75, 23);
            this.deleteNumberButton.TabIndex = 11;
            this.deleteNumberButton.Text = "Delete number";
            this.deleteNumberButton.UseVisualStyleBackColor = true;
            // 
            // addNumberButton
            // 
            this.addNumberButton.Location = new System.Drawing.Point(227, 26);
            this.addNumberButton.Name = "addNumberButton";
            this.addNumberButton.Size = new System.Drawing.Size(75, 23);
            this.addNumberButton.TabIndex = 10;
            this.addNumberButton.Text = "Add number";
            this.addNumberButton.UseVisualStyleBackColor = true;
            this.addNumberButton.Click += new System.EventHandler(this.addNumberButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "New number";
            // 
            // newTelNumberTb
            // 
            this.newTelNumberTb.Location = new System.Drawing.Point(87, 28);
            this.newTelNumberTb.Name = "newTelNumberTb";
            this.newTelNumberTb.Size = new System.Drawing.Size(134, 20);
            this.newTelNumberTb.TabIndex = 1;
            // 
            // telNumberList
            // 
            this.telNumberList.FormattingEnabled = true;
            this.telNumberList.Location = new System.Drawing.Point(6, 54);
            this.telNumberList.Name = "telNumberList";
            this.telNumberList.Size = new System.Drawing.Size(382, 56);
            this.telNumberList.TabIndex = 0;
            // 
            // AddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 320);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.telAdd);
            this.Name = "AddPerson";
            this.Text = "Add person";
            this.Load += new System.EventHandler(this.AddPerson_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telNumbersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button telAdd;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.TextBox addressTb;
        private System.Windows.Forms.TextBox surnameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deleteNumberButton;
        private System.Windows.Forms.Button addNumberButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newTelNumberTb;
        private System.Windows.Forms.ListBox telNumberList;
        private System.Windows.Forms.BindingSource telNumbersBindingSource;
    }
}

