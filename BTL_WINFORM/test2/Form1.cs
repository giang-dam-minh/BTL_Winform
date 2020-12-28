using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test2
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            User u = db.Users.SingleOrDefault(d => d.ID==1);
            textBox1.Text = u.Active.ToString();
        }

        private void test(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("thoat?", "thong bao", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

            }
            else
            {
                e.Cancel=true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if(dlg.ShowDialog()==DialogResult.OK)
              MessageBox.Show(dlg.FileName);
        }
    }
}
