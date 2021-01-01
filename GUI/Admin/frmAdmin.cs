using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
namespace GUI
{
    public partial class frmAdmin : Form
    {

        BUS_Offices bus_office = new BUS_Offices();
        BUS_Users bus_user = new BUS_Users();
        BUS_Hisroty bus_history = new BUS_Hisroty();
        string email;
        DateTime date;
        TimeSpan timeIn;
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            email = this.Tag.ToString();
            date = DateTime.Today;
            timeIn = TimeSpan.Parse(DateTime.Now.ToString("hh:mm:ss"));
            bus_history.addHistory(email, date, timeIn);
            bus_office.getOfficeNameToComboBox(cbbOffices);
            bus_user.DisplayDataByOfficeName(cbbOffices.Text,grvListUsers);         
        }

        private void cbbOffices_SelectedIndexChanged(object sender, EventArgs e)
        {
            bus_user.DisplayDataByOfficeName(cbbOffices.Text, grvListUsers);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Exit?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                TimeSpan timeOut = TimeSpan.Parse(DateTime.Now.ToString("hh:mm:ss"));
                bus_history.upDateTimeOut(email, date, timeIn, timeOut, "");
                this.Close();
            }
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUser frm = new frmAddUser();
            frm.ShowDialog();
      
        }

        private void addUserFromCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImportUser frm = new frmImportUser();
            frm.ShowDialog();
        }

        private void addUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddUser frm = new frmAddUser();
            frm.ShowDialog();
        }

        private void btnChangRole_Click(object sender, EventArgs e)
        {
            frmEditRole frm = new frmEditRole();
            frm.ShowDialog();
        }

        private void btnEDLogin_Click(object sender, EventArgs e)
        {
            int i=grvListUsers.SelectedCells[0].RowIndex;
            DataGridViewRow row=grvListUsers.Rows[i];
            bus_user.changeActiveByEmail(row.Cells["EmailAddres"].Value.ToString());
            bus_user.DisplayDataByOfficeName(cbbOffices.Text, grvListUsers);
            MessageBox.Show("Change Active sucessed");
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = grvListUsers.SelectedCells[0].RowIndex;
            DataGridViewRow row = grvListUsers.Rows[i];
            if (bus_user.checkActiviveByEmail(row.Cells["EmailAddres"].Value.ToString()))
            {
                btnEDLogin.Text = "Disable Login";
            }
            else
            {
                btnEDLogin.Text = "Enable Login";
            }
        }

        private void controlLogoutLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogoutDetected frm = new frmLogoutDetected();
            frm.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {   
         DialogResult rs=   MessageBox.Show("Are you want logout?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
         if (rs == DialogResult.Yes)
         {
             frmLogin frm = new frmLogin();
             frm.Show();
             this.Dispose();
         }
        }

        private void frmAdmin_Activated(object sender, EventArgs e)
        {
            bus_user.DisplayDataByOfficeName(cbbOffices.Text, grvListUsers);         
        }

        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Exit?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                TimeSpan timeOut = TimeSpan.Parse(DateTime.Now.ToString("hh:mm:ss"));
                bus_history.upDateTimeOut(email, date, timeIn, timeOut, "");
            }
            else
                e.Cancel = true;
        }
    }
}
