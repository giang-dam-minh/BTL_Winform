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
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
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
                this.Dispose();
            }
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
        }

        private void controlLogoutLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmControlOutIn frm = new frmControlOutIn();
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
    }
}
