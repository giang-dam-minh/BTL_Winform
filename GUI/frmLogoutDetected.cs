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
    public partial class frmLogoutDetected : Form
    {
        TimeSpan timeIn = TimeSpan.Parse(DateTime.Now.ToString("hh:mm:ss"));
        BUS_Users bus_user = new BUS_Users();
        BUS_Hisroty bus_history = new BUS_Hisroty();
        string email;
        DateTime date;
        TimeSpan time;
        public frmLogoutDetected()
        {
            InitializeComponent();
        }

        private void frmControlOutIn_Load(object sender, EventArgs e)
        {
            email = this.Tag.ToString();
            string date = bus_history.getFinalDateLoginByEmail(email);
            time = bus_history.getFinalTimeLoginByEmail(email);         
            lblIntroCrash.Text = "No logout detected for tour last login on " + date.Substring(0,8) + " at " + time;
        }

        private void cbbEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
              
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string reason = "";
            if (RBSoftware.Checked)
                reason += "Software Crash, ";
            if (RBSystem.Checked)
            {
                reason += "System Crash, ";
            }
            reason += listReason.Text;
            if(!string.IsNullOrEmpty(reason))
                 bus_history.updateReason(email, reason);
            this.Close();
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
