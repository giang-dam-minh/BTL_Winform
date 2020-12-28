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
    public partial class frmUser : Form
    {
        string email;
        DateTime date;
        TimeSpan timeIn;
        TimeSpan sumTimeUsed;
        BUS_Hisroty bus_history = new BUS_Hisroty();
        BUS_Users bus_user = new BUS_Users();
        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {          
            email = this.Tag.ToString();
            date = DateTime.Today;
            timeIn = TimeSpan.Parse(DateTime.Now.ToString("hh:mm:ss"));
            sumTimeUsed = TimeSpan.Parse(bus_history.getSumTimeUseByEmail(email).ToString());
            bus_history.addHistory(email,date,timeIn);
            bus_history.DisplayByEmail(grvHistory, email,timeIn);
            lbHello.Text = "Hi " + bus_user.getFNameByEmail(email) + " ,Welcome to AMONIC Airlines";
            label4.Text = bus_history.getCrashByEmail(email,timeIn).ToString();
            bus_history.changeColor(grvHistory);
            timer1.Start();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Exit?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                TimeSpan timeOut = TimeSpan.Parse(DateTime.Now.ToString("hh:mm:ss"));
                bus_history.upDateTimeOut(email, date, timeIn, timeOut,"");
                this.Close();
            }
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int i = grvHistory.SelectedCells[0].RowIndex;
            //DataGridViewRow row = grvHistory.Rows[i];
            //if (row.Cells["LogoutReason"].Value == null)
            //    MessageBox.Show("null");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            timer1.Interval = 1000;
            lbTimeOn.Text = (sumTimeUsed+ TimeSpan.Parse(now.ToString("hh:mm:ss")) - timeIn).ToString();
        }
    }
}
