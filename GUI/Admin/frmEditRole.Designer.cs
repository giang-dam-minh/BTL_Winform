namespace GUI
{
    partial class frmEditRole
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
            this.cbbOffice = new System.Windows.Forms.ComboBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RBAdmin = new System.Windows.Forms.RadioButton();
            this.RBUser = new System.Windows.Forms.RadioButton();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbbEmail = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbbOffice
            // 
            this.cbbOffice.FormattingEnabled = true;
            this.cbbOffice.Location = new System.Drawing.Point(132, 136);
            this.cbbOffice.Name = "cbbOffice";
            this.cbbOffice.Size = new System.Drawing.Size(177, 21);
            this.cbbOffice.TabIndex = 21;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(132, 103);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(177, 20);
            this.txtLName.TabIndex = 20;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(132, 70);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(177, 20);
            this.txtFName.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Office";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Last name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "First name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Email address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Role";
            // 
            // RBAdmin
            // 
            this.RBAdmin.AutoSize = true;
            this.RBAdmin.Location = new System.Drawing.Point(115, 207);
            this.RBAdmin.Name = "RBAdmin";
            this.RBAdmin.Size = new System.Drawing.Size(85, 17);
            this.RBAdmin.TabIndex = 23;
            this.RBAdmin.TabStop = true;
            this.RBAdmin.Text = "Administrator";
            this.RBAdmin.UseVisualStyleBackColor = true;
            // 
            // RBUser
            // 
            this.RBUser.AutoSize = true;
            this.RBUser.Location = new System.Drawing.Point(115, 231);
            this.RBUser.Name = "RBUser";
            this.RBUser.Size = new System.Drawing.Size(47, 17);
            this.RBUser.TabIndex = 24;
            this.RBUser.TabStop = true;
            this.RBUser.Text = "User";
            this.RBUser.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(61, 298);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 25;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(168, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbbEmail
            // 
            this.cbbEmail.FormattingEnabled = true;
            this.cbbEmail.Location = new System.Drawing.Point(132, 36);
            this.cbbEmail.Name = "cbbEmail";
            this.cbbEmail.Size = new System.Drawing.Size(177, 21);
            this.cbbEmail.TabIndex = 27;
            this.cbbEmail.SelectedIndexChanged += new System.EventHandler(this.cbbEmail_SelectedIndexChanged);
            // 
            // frmEditRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 353);
            this.Controls.Add(this.cbbEmail);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.RBUser);
            this.Controls.Add(this.RBAdmin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbOffice);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEditRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Role";
            this.Load += new System.EventHandler(this.frmEditRole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbOffice;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton RBAdmin;
        private System.Windows.Forms.RadioButton RBUser;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbbEmail;
    }
}