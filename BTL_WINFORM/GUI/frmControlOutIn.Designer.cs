namespace GUI
{
    partial class frmLogoutDetected
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listReason = new System.Windows.Forms.RichTextBox();
            this.RBSoftware = new System.Windows.Forms.RadioButton();
            this.RBSystem = new System.Windows.Forms.RadioButton();
            this.lblIntroCrash = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reason:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(433, 388);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Reason:";
            // 
            // listReason
            // 
            this.listReason.Location = new System.Drawing.Point(104, 114);
            this.listReason.Name = "listReason";
            this.listReason.Size = new System.Drawing.Size(640, 258);
            this.listReason.TabIndex = 9;
            this.listReason.Text = "";
            // 
            // RBSoftware
            // 
            this.RBSoftware.AutoSize = true;
            this.RBSoftware.Location = new System.Drawing.Point(196, 394);
            this.RBSoftware.Name = "RBSoftware";
            this.RBSoftware.Size = new System.Drawing.Size(97, 17);
            this.RBSoftware.TabIndex = 12;
            this.RBSoftware.TabStop = true;
            this.RBSoftware.Text = "Software Crash";
            this.RBSoftware.UseVisualStyleBackColor = true;
            this.RBSoftware.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.RBSoftware.Click += new System.EventHandler(this.click);
            // 
            // RBSystem
            // 
            this.RBSystem.AutoSize = true;
            this.RBSystem.Location = new System.Drawing.Point(301, 394);
            this.RBSystem.Name = "RBSystem";
            this.RBSystem.Size = new System.Drawing.Size(89, 17);
            this.RBSystem.TabIndex = 13;
            this.RBSystem.TabStop = true;
            this.RBSystem.Text = "System Crash";
            this.RBSystem.UseVisualStyleBackColor = true;
            // 
            // lblIntroCrash
            // 
            this.lblIntroCrash.AutoSize = true;
            this.lblIntroCrash.Location = new System.Drawing.Point(101, 24);
            this.lblIntroCrash.Name = "lblIntroCrash";
            this.lblIntroCrash.Size = new System.Drawing.Size(35, 13);
            this.lblIntroCrash.TabIndex = 14;
            this.lblIntroCrash.Text = "label3";
            // 
            // frmLogoutDetected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 469);
            this.Controls.Add(this.lblIntroCrash);
            this.Controls.Add(this.RBSystem);
            this.Controls.Add(this.RBSoftware);
            this.Controls.Add(this.listReason);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label1);
            this.Name = "frmLogoutDetected";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "No logout detected";
            this.Load += new System.EventHandler(this.frmControlOutIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox listReason;
        private System.Windows.Forms.RadioButton RBSoftware;
        private System.Windows.Forms.RadioButton RBSystem;
        private System.Windows.Forms.Label lblIntroCrash;
    }
}