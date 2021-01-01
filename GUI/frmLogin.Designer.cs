namespace GUI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.Username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmailLogin = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbSecond = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(248, 214);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(55, 13);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtEmailLogin
            // 
            this.txtEmailLogin.Location = new System.Drawing.Point(309, 211);
            this.txtEmailLogin.Name = "txtEmailLogin";
            this.txtEmailLogin.Size = new System.Drawing.Size(117, 20);
            this.txtEmailLogin.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(309, 248);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(117, 20);
            this.txtPass.TabIndex = 3;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(251, 350);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(351, 350);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(251, 300);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(0, 13);
            this.lbTime.TabIndex = 6;
            // 
            // lbSecond
            // 
            this.lbSecond.AutoSize = true;
            this.lbSecond.Location = new System.Drawing.Point(324, 299);
            this.lbSecond.Name = "lbSecond";
            this.lbSecond.Size = new System.Drawing.Size(0, 13);
            this.lbSecond.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(42, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 164);
            this.panel1.TabIndex = 8;
            // 
            // cbPass
            // 
            this.cbPass.AutoSize = true;
            this.cbPass.Location = new System.Drawing.Point(309, 279);
            this.cbPass.Name = "cbPass";
            this.cbPass.Size = new System.Drawing.Size(102, 17);
            this.cbPass.TabIndex = 9;
            this.cbPass.Text = "Show Password\r\n";
            this.cbPass.UseVisualStyleBackColor = true;
            this.cbPass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(752, 416);
            this.Controls.Add(this.cbPass);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbSecond);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtEmailLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Username);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmailLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbSecond;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbPass;
    }
}