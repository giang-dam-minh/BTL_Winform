namespace GUI
{
    partial class frmAdmin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChangRole = new System.Windows.Forms.Button();
            this.btnEDLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbOffices = new System.Windows.Forms.ComboBox();
            this.grvListUsers = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvListUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1029, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.addUserToolStripMenuItem.Text = "Add user";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnChangRole
            // 
            this.btnChangRole.Location = new System.Drawing.Point(222, 355);
            this.btnChangRole.Name = "btnChangRole";
            this.btnChangRole.Size = new System.Drawing.Size(121, 23);
            this.btnChangRole.TabIndex = 4;
            this.btnChangRole.Text = "Change Role";
            this.btnChangRole.UseVisualStyleBackColor = true;
            this.btnChangRole.Click += new System.EventHandler(this.btnChangRole_Click);
            // 
            // btnEDLogin
            // 
            this.btnEDLogin.Location = new System.Drawing.Point(384, 355);
            this.btnEDLogin.Name = "btnEDLogin";
            this.btnEDLogin.Size = new System.Drawing.Size(124, 23);
            this.btnEDLogin.TabIndex = 5;
            this.btnEDLogin.Text = "Enable/Disable Login";
            this.btnEDLogin.UseVisualStyleBackColor = true;
            this.btnEDLogin.Click += new System.EventHandler(this.btnEDLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Office:";
            // 
            // cbbOffices
            // 
            this.cbbOffices.FormattingEnabled = true;
            this.cbbOffices.Items.AddRange(new object[] {
            "All"});
            this.cbbOffices.Location = new System.Drawing.Point(222, 77);
            this.cbbOffices.Name = "cbbOffices";
            this.cbbOffices.Size = new System.Drawing.Size(121, 21);
            this.cbbOffices.TabIndex = 2;
            this.cbbOffices.SelectedIndexChanged += new System.EventHandler(this.cbbOffices_SelectedIndexChanged);
            // 
            // grvListUsers
            // 
            this.grvListUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvListUsers.Location = new System.Drawing.Point(222, 116);
            this.grvListUsers.Name = "grvListUsers";
            this.grvListUsers.Size = new System.Drawing.Size(645, 233);
            this.grvListUsers.TabIndex = 3;
            this.grvListUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 525);
            this.Controls.Add(this.btnEDLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangRole);
            this.Controls.Add(this.cbbOffices);
            this.Controls.Add(this.grvListUsers);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANOMIC Airlines Automation System";
            this.Activated += new System.EventHandler(this.frmAdmin_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdmin_FormClosing);
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvListUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnChangRole;
        private System.Windows.Forms.Button btnEDLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbOffices;
        private System.Windows.Forms.DataGridView grvListUsers;
    }
}