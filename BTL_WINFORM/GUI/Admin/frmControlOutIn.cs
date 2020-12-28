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
    public partial class frmControlOutIn : Form
    {
        TimeSpan timeIn = TimeSpan.Parse(DateTime.Now.ToString("hh:mm:ss"));
        BUS_Users bus_user = new BUS_Users();
        BUS_Hisroty bus_history = new BUS_Hisroty();
        public frmControlOutIn()
        {
            InitializeComponent();
        }

        private void frmControlOutIn_Load(object sender, EventArgs e)
        {
            bus_user.getEmailToComboBox(cbbEmail);
            bus_history.DisplayAll(grvCrash);
            bus_history.changeColor(grvCrash);
        }

        private void cbbEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            bus_history.DisplayByEmail(grvCrash, cbbEmail.Text,timeIn);
            bus_history.changeColor(grvCrash);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
              
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int i=grvCrash.SelectedCells[0].RowIndex;
            DataGridViewRow row=grvCrash.Rows[i];
            string email = row.Cells["Email"].Value.ToString();
            DateTime date =Convert.ToDateTime(row.Cells["Date"].Value.ToString());
            TimeSpan timeIn = TimeSpan.Parse(row.Cells["LoginTime"].Value.ToString());
            string reason = listReason.Text;
            if (RBSoftware.Checked)
                reason += " Software Crash";
            if (RBSystem.Checked)
                reason += " System Crash";
            bus_history.updateReason(email, date, timeIn, reason);
            bus_history.DisplayAll(grvCrash);
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CBSystemCrash_CheckedChanged(object sender, EventArgs e)
        {
       
        }

        private void CBSoftwareCrash_CheckedChanged(object sender, EventArgs e)
        {
    
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void click(object sender, EventArgs e)
        {
            
        }
    }
}
