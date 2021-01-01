using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using System.Threading;
namespace GUI
{
    public partial class frmLogin : Form
    {
        BUS_Users bus_user = new BUS_Users();
        BUS_Login bus_login = new BUS_Login();
        BUS_Hisroty bus_history = new BUS_Hisroty();
        private System.Windows.Forms.Timer aTimer;
        int counter = 11;
        static int dem = 0;
        public frmLogin()
        {
            InitializeComponent();
        }
        private void aTimer_Tick(object sender, EventArgs e)
        {
            counter--;
            lbSecond.Text =""+ counter.ToString() + "s";
            if (counter < 0)
            {
                aTimer.Stop();
                txtEmailLogin.Enabled = true;
                txtPass.Enabled = true;
                btnLogin.Enabled = true;
                counter = 11;
                dem = 0;
                lbSecond.Text = "";
            }
        }
        private void runTimeOut()
        {
            txtEmailLogin.Enabled = false;
            txtPass.Enabled = false;
            btnLogin.Enabled = false;
            aTimer = new System.Windows.Forms.Timer();
            aTimer.Tick += new EventHandler(aTimer_Tick);
            aTimer.Interval = 1000; // 1 second
            aTimer.Start();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            int checkLogin = bus_user.Login(txtEmailLogin.Text, txtPass.Text);
           
            if (dem ==2)
            {
                runTimeOut();
                lbTime.Text = "Waiting Time:";
            }
            if (checkLogin == 1)
            {
                int checkRole = bus_user.getRoleIdByEmail(txtEmailLogin.Text);
                if (checkRole == 1)
                {
                    frmAdmin frm = new frmAdmin();
                    frm.Tag = txtEmailLogin.Text;
                    if (!bus_history.checkFinalLogoutByEmail(txtEmailLogin.Text))
                    {
                        frmLogoutDetected frmLD = new frmLogoutDetected();
                        frmLD.Tag = txtEmailLogin.Text;
                        frmLD.ShowDialog();
                    }
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    frmUser frm = new frmUser();
                    frm.Tag = txtEmailLogin.Text;
                    if (!bus_history.checkFinalLogoutByEmail(txtEmailLogin.Text))
                    {
                        frmLogoutDetected frmLD = new frmLogoutDetected();
                        frmLD.Tag = txtEmailLogin.Text;
                        frmLD.ShowDialog();
                    }
                    frm.Show();
                    this.Hide();
                }
            }
            else if (checkLogin == 0)
            {
                MessageBox.Show("username or password fail");
                dem++;
            }
            else if (checkLogin == -1)
            {
                MessageBox.Show("your account is non-activity");
                dem++;
            }
            else if (checkLogin == -2)
                MessageBox.Show("server error! Please try again");
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void Login(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin_Click(sender,e);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPass.Checked == true)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }
    }
}
